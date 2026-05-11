using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EventManagementSystem
{
    /// <summary>
    /// A modern gradient button. Default = sky blue → purple.
    /// Reused on every form to keep design consistent.
    /// </summary>
    public class GradientButton : Button
    {
        public Color StartColor { get; set; } = Color.FromArgb(93, 173, 226);   // sky blue
        public Color EndColor { get; set; } = Color.FromArgb(134, 87, 220);   // deep purple
        public LinearGradientMode Mode { get; set; } = LinearGradientMode.Horizontal;
        public int CornerRadius { get; set; } = 0;

        public GradientButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            ForeColor = Color.White;
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var brush = new LinearGradientBrush(ClientRectangle, StartColor, EndColor, Mode))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}