// Emin Nuriyev - 819768073
// Irakli Bajelidze - 819818981

using System.Windows.Forms;
using System.Drawing;

namespace Tetris
{
    class Custom : Control  // overall represesnts an empty control for all buttons in the game
    {
        private StringFormat stringFormat = new StringFormat();
        public SolidBrush textBrush;

        public Custom()
        {
            textBrush = new SolidBrush(Color.DimGray);
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            
            this.Paint += Custom_Paint;
        }

        private void Custom_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(this.Text, this.Font, textBrush, new PointF(this.Width/2, this.Height/2), stringFormat);
        }
    }
}
