using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CertificateGenerator.Utility_Side_Classes
{
    public class BorderedPanel : Panel
    {
        private Color _borderColor;
        [Browsable(true)]
        [Category("Appearance")]
        [DisplayName("Border Color")]
        [Description("Sets the color of the custom picture box border")]
        public Color BorderColor
        {
            set { _borderColor = value; Invalidate(); }
            get { return _borderColor; }
        }

        public BorderedPanel()
        {
            Paint += NewPaint;
        }
        private void NewPaint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, _borderColor, ButtonBorderStyle.Solid);
        }
    }
}
