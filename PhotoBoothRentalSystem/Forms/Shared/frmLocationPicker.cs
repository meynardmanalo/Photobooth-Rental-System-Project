using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PhotoBoothRentalSystem.Forms.Shared
{
    // ════════════════════════════════════════════════════════
    //  Location Picker — interactive map using Leaflet.js
    //  User clicks/searches to drop a pin, then confirms.
    //  Returns: SelectedAddress (string)
    // ════════════════════════════════════════════════════════
    public partial class frmLocationPicker : Form
    {
        public string SelectedAddress { get; private set; } = "";

        // Bridge object so JavaScript can call back into C#
        [ComVisible(true)]
        public class MapBridge
        {
            private readonly frmLocationPicker _owner;
            public MapBridge(frmLocationPicker owner) { _owner = owner; }

            public void SetAddress(string address)
            {
                _owner.Invoke((Action)(() =>
                {
                    _owner.txtAddress.Text = address;
                    _owner.SelectedAddress  = address;
                }));
            }
        }

        public frmLocationPicker(string currentAddress = "")
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(currentAddress))
            {
                txtAddress.Text = currentAddress;
                SelectedAddress  = currentAddress;
            }
        }

        private void frmLocationPicker_Load(object sender, EventArgs e)
        {
            // Allow modern JavaScript in WebBrowser (IE11 mode via feature control)
            SetBrowserFeatureControl();

            webMap.ObjectForScripting = new MapBridge(this);
            webMap.DocumentText = BuildMapHtml();
        }

        private static void SetBrowserFeatureControl()
        {
            // Force IE11 rendering for the WebBrowser control
            try
            {
                string appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
                var regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                    @"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
                if (regKey == null)
                    regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(
                        @"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION");
                regKey?.SetValue(appName, 11001, Microsoft.Win32.RegistryValueKind.DWord);
                regKey?.Close();
            }
            catch { }
        }

        private string BuildMapHtml()
        {
            // Central Luzon, Philippines center
            return @"<!DOCTYPE html>
<html>
<head>
<meta charset='utf-8'/>
<meta name='viewport' content='width=device-width,initial-scale=1'/>
<title>Pick Location</title>
<link rel='stylesheet' href='https://unpkg.com/leaflet@1.9.4/dist/leaflet.css'/>
<script src='https://unpkg.com/leaflet@1.9.4/dist/leaflet.js'></script>
<style>
  * { margin:0; padding:0; box-sizing:border-box; }
  body { font-family: Segoe UI, sans-serif; background:#f5f5f5; }
  #searchBox { width:100%; padding:8px 12px; font-size:14px; border:none; border-bottom:2px solid #e74c3c; outline:none; }
  #map { width:100%; height: calc(100vh - 44px); }
  #pin-hint { position:absolute; bottom:10px; left:50%; transform:translateX(-50%);
    background:rgba(0,0,0,0.6); color:white; padding:6px 14px; border-radius:20px;
    font-size:12px; pointer-events:none; z-index:1000; }
</style>
</head>
<body>
<input id='searchBox' type='text' placeholder='Search for a place in Central Luzon...'/>
<div id='map'></div>
<div id='pin-hint'>Click anywhere on the map to drop a pin</div>
<script>
var map = L.map('map').setView([15.4827, 120.9116], 10); // Central Luzon
L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
  attribution: '© OpenStreetMap contributors', maxZoom: 19
}).addTo(map);

var marker = null;

function dropPin(lat, lng) {
  if (marker) map.removeLayer(marker);
  marker = L.marker([lat, lng], { draggable: true }).addTo(map);
  marker.on('dragend', function(e) {
    reverseGeocode(e.target.getLatLng().lat, e.target.getLatLng().lng);
  });
  reverseGeocode(lat, lng);
}

function reverseGeocode(lat, lng) {
  var url = 'https://nominatim.openstreetmap.org/reverse?format=json&lat=' + lat + '&lon=' + lng + '&zoom=18&addressdetails=1';
  var xhr = new XMLHttpRequest();
  xhr.open('GET', url, true);
  xhr.setRequestHeader('Accept-Language', 'en');
  xhr.onreadystatechange = function() {
    if (xhr.readyState === 4 && xhr.status === 200) {
      var data = JSON.parse(xhr.responseText);
      var addr = data.display_name || (lat.toFixed(6) + ', ' + lng.toFixed(6));
      window.external.SetAddress(addr);
    }
  };
  xhr.send();
}

map.on('click', function(e) {
  dropPin(e.latlng.lat, e.latlng.lng);
});

// Search on Enter
document.getElementById('searchBox').addEventListener('keydown', function(e) {
  if (e.key === 'Enter' || e.keyCode === 13) {
    var q = this.value.trim();
    if (!q) return;
    var url = 'https://nominatim.openstreetmap.org/search?format=json&q=' + encodeURIComponent(q) + '&countrycodes=ph&limit=1';
    var xhr = new XMLHttpRequest();
    xhr.open('GET', url, true);
    xhr.onreadystatechange = function() {
      if (xhr.readyState === 4 && xhr.status === 200) {
        var results = JSON.parse(xhr.responseText);
        if (results.length > 0) {
          var r = results[0];
          map.setView([r.lat, r.lon], 16);
          dropPin(parseFloat(r.lat), parseFloat(r.lon));
        } else {
          alert('Location not found. Try a different search term.');
        }
      }
    };
    xhr.send();
  }
});
</script>
</body>
</html>";
        }

        private void btnUseLocation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please click on the map or search to select a location.",
                    "No Location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SelectedAddress  = txtAddress.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            SelectedAddress = txtAddress.Text.Trim();
        }
    }
}
