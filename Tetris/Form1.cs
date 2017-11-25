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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //
        // Main Menu Buttons
        //
        private void mainMenuButtons_MouseEnter(object sender, EventArgs e)
        {
            ((Custom)sender).BackgroundImage = global::Tetris.Properties.Resources.selected;
            ((Custom)sender).textBrush = new SolidBrush(Color.Green);
        }

        private void mainMenuButtons_MouseLeave(object sender, EventArgs e)
        {
            ((Custom)sender).BackgroundImage = global::Tetris.Properties.Resources.notSelected;
            ((Custom)sender).textBrush = new SolidBrush(Color.DimGray);
        }

        //
        // Exit Button
        //
        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackgroundImage = global::Tetris.Properties.Resources.exitSelected;
            exitButton.textBrush = new SolidBrush(Color.DarkRed);
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackgroundImage = global::Tetris.Properties.Resources.exit;
            exitButton.textBrush = new SolidBrush(Color.DimGray);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            checkSurePanel.Visible = true;
            checkSurePanel.Enabled = true;

            foreach (Control c in mainMenuPanel.Controls)
            {
                if (c is PictureBox || c is Panel)
                {
                    continue;
                }
                else
                {
                    c.Enabled = false;
                }
            }
        }

        //
        // Check Sure Panel Buttons
        //
        private void sureYesLabel_MouseEnter(object sender, EventArgs e)
        {
            sureYesLabel.ForeColor = Color.Green;
            //sureYesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void sureNoLabel_MouseEnter(object sender, EventArgs e)
        {
            sureNoLabel.ForeColor = Color.Red;
        }

        private void sureYesLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void sureYesNoLabel_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.DimGray;
        }

        private void sureNoLabel_Click(object sender, EventArgs e)
        {
            checkSurePanel.Enabled = false;
            checkSurePanel.Visible = false;

            foreach (Control c in mainMenuPanel.Controls)
            {
                if (c is Panel)
                {
                    continue;
                }
                c.Enabled = true;
            }
        }

        //
        // Play Button Menu
        //
        private void playButton_Click(object sender, EventArgs e)
        {

        }
    }
}
