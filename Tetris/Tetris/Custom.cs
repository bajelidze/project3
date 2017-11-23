using System.Windows.Forms;
using System.Drawing;
using System;

namespace Tetris
{
    class Custom : Control
    {
        public Custom()
        {
            this.BackgroundImage = global::Tetris.Properties.Resources.selectedNew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paint += Custom_Paint;
        }

        private void Custom_Paint(object sender, PaintEventArgs e)
        {
           // e.Graphics.DrawString(this.Text, this.Font, 30, 30);
        }
    }
}
