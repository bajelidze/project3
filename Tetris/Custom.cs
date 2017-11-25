using System.Windows.Forms;
using System.Drawing;
using System;

namespace Tetris
{
    class Custom : Control
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
