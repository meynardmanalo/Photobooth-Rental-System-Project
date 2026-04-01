using System;
using System.Drawing;

namespace PhotoBoothRentalSystem.Classes.Utilities
{
    /// <summary>
    /// Central theme/color settings. Change values here to restyle the whole app.
    /// </summary>
    public static class ThemeManager
    {
        // ── Brand Colors ──────────────────────────────────────
        public static Color Primary     = Color.FromArgb(231, 76,  60);   // red
        public static Color Secondary   = Color.FromArgb(52,  152, 219);  // blue
        public static Color Success     = Color.FromArgb(39,  174, 96);   // green
        public static Color Warning     = Color.FromArgb(241, 196, 15);   // yellow
        public static Color Dark        = Color.FromArgb(44,  62,  80);   // dark navy
        public static Color Light       = Color.FromArgb(245, 245, 245);  // off-white
        public static Color CardBg      = Color.White;
        public static Color CardBorder  = Color.FromArgb(230, 230, 230);

        // ── Package Type Colors ───────────────────────────────
        public static Color GetPackageTypeColor(string packageType)
        {
            if (string.IsNullOrWhiteSpace(packageType)) return Primary;
            switch (packageType.ToLower().Trim())
            {
                case "basic":    return Color.FromArgb(52,  152, 219);  // blue
                case "standard": return Color.FromArgb(39,  174, 96);   // green
                case "premium":  return Color.FromArgb(155, 89,  182);  // purple
                case "deluxe":   return Color.FromArgb(243, 156, 18);   // gold
                case "wedding":  return Color.FromArgb(233, 30,  99);   // pink
                case "mini":     return Color.FromArgb(26,  188, 156);  // teal
                case "vip":      return Color.FromArgb(44,  62,  80);   // dark
                default:         return Primary;
            }
        }

        // ── Fonts ─────────────────────────────────────────────
        public static Font FontTitle    = new Font("Segoe UI", 13F, FontStyle.Bold);
        public static Font FontSubtitle = new Font("Segoe UI", 9F);
        public static Font FontPrice    = new Font("Segoe UI", 16F, FontStyle.Bold);
        public static Font FontSmall    = new Font("Segoe UI", 8F);
        public static Font FontButton   = new Font("Segoe UI", 10F, FontStyle.Bold);
    }
}
