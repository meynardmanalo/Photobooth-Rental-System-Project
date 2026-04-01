using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoBoothRentalSystem.Forms.Shared
{
    public partial class frmLoading : Form
    {
        private int _dots = 0;
        private string _message = "Loading";

        public frmLoading(string message = "Loading")
        {
            InitializeComponent();
            _message = message;
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            lblMessage.Text = _message + "...";
            timerDots.Start();
        }

        private void timerDots_Tick(object sender, EventArgs e)
        {
            _dots = (_dots + 1) % 4;
            lblMessage.Text = _message + new string('.', _dots);
        }

        public static async Task<T> RunWithLoading<T>(string message, Func<Task<T>> work)
        {
            T result = default;
            using (var frm = new frmLoading(message))
            {
                frm.Show();
                Application.DoEvents();
                result = await work();
                frm.Close();
            }
            return result;
        }

        public static async Task RunWithLoading(string message, Func<Task> work)
        {
            using (var frm = new frmLoading(message))
            {
                frm.Show();
                Application.DoEvents();
                await work();
                frm.Close();
            }
        }
    }
}
