using System.Windows.Forms;
using System.Drawing;
using System;

namespace Tetris
{
    class Custom : Control
    {
        public float BorderThickness { get; set; } = 1;
        private Rectangle borderRectangle;
        private SolidBrush borderBrush;

        public Custom()
        {
            borderBrush = new SolidBrush(Color.Black);
            this.Paint += FlatButton_Paint;
        }

        private void FlatButton_Paint(object sender, PaintEventArgs e)
        {
            borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
        }
    }
}
