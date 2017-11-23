using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            button.Visible = false;
        }

        private void custom_Enter(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            button.BackgroundImage = global::Tetris.Properties.Resources.selected;
            button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void custom_MouseLeave(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            button.BackgroundImage = global::Tetris.Properties.Resources.selectedNew;
            button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
