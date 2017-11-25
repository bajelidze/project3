using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tetris
{
    public partial class Form : System.Windows.Forms.Form
    {
        private SoundPlayer Player = new SoundPlayer();
        private bool sfxMuted = false;
        private bool musicMuted = false;

        public Form()
        {
            InitializeComponent();
            musicButton1.BackgroundImage = global::Tetris.Properties.Resources.music;
            musicButton2.BackgroundImage = global::Tetris.Properties.Resources.music;
            musicButton3.BackgroundImage = global::Tetris.Properties.Resources.music;
            sfxButton1.BackgroundImage = global::Tetris.Properties.Resources.sfx;
            sfxButton2.BackgroundImage = global::Tetris.Properties.Resources.sfx;
            sfxButton3.BackgroundImage = global::Tetris.Properties.Resources.sfx;
            Game game = new Game();
            try
            {
                this.Player.SoundLocation = Environment.CurrentDirectory + @"\sound\theme1.wav";
                this.Player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            if (sender == menuButton)
            {
                menuButton.BackgroundImage = global::Tetris.Properties.Resources.menuButtonSelected;
                menuButton.textBrush = new SolidBrush(Color.Green);
            }
            else if (sender == exitButton)
            {
                exitButton.BackgroundImage = global::Tetris.Properties.Resources.exitSelected;
                exitButton.textBrush = new SolidBrush(Color.DarkRed);
            }
            else if (sender == sureYesLabel)
            {
                sureYesLabel.ForeColor = Color.Green;
            }
            else if(sender == sureNoLabel)
            {
                sureNoLabel.ForeColor = Color.Red;
            }
            else
            {
                ((Custom)sender).BackgroundImage = global::Tetris.Properties.Resources.selected;
                ((Custom)sender).textBrush = new SolidBrush(Color.Green);
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            if (sender == menuButton)
            {
                menuButton.BackgroundImage = global::Tetris.Properties.Resources.menuButton;
                menuButton.textBrush = new SolidBrush(Color.DimGray);
            }
            else if (sender == exitButton)
            {
                exitButton.BackgroundImage = global::Tetris.Properties.Resources.exit;
                exitButton.textBrush = new SolidBrush(Color.DimGray);
            }
            else if(sender == sureYesLabel)
            {
                sureYesLabel.ForeColor = Color.DimGray;
            }
            else if(sender == sureNoLabel)
            {
                sureNoLabel.ForeColor = Color.DimGray;
            }
            else
            {
                ((Custom)sender).BackgroundImage = global::Tetris.Properties.Resources.notSelected;
                ((Custom)sender).textBrush = new SolidBrush(Color.DimGray);
            }
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

        private void sureYesLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
            playMenuPanel.Enabled = true;
            playMenuPanel.Visible = true;

            foreach (Control c in mainMenuPanel.Controls)
            {
                if (c is Panel)
                {
                    continue;
                }
                c.Enabled = false;
                c.Visible = false;
            } 
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in mainMenuPanel.Controls)
            {
                if (c is Panel)
                {
                    continue;
                }
                c.Enabled = true;
                c.Visible = true;
            }

            playMenuPanel.Enabled = false;
            playMenuPanel.Visible = false;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in playMenuPanel.Controls)
            {
                if (c is Panel)
                {
                    continue;
                }
                c.Enabled = false;
                c.Visible = false;
            }
            gamePanel.Enabled = true;
            gamePanel.Visible = true;
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            if(musicMuted == false)
            {
                musicMuted = true;
                musicButton1.BackgroundImage = global::Tetris.Properties.Resources.musicMuted;
                musicButton2.BackgroundImage = global::Tetris.Properties.Resources.musicMuted;
                musicButton3.BackgroundImage = global::Tetris.Properties.Resources.musicMuted;
                Player.Stop();
            }
            else
            {
                try
                {
                    this.Player.SoundLocation = Environment.CurrentDirectory + @"\sound\theme1.wav";
                    this.Player.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error playing sound");
                }

                musicMuted = false;
                musicButton1.BackgroundImage = global::Tetris.Properties.Resources.music;
                musicButton2.BackgroundImage = global::Tetris.Properties.Resources.music;
                musicButton3.BackgroundImage = global::Tetris.Properties.Resources.music;
            }
        }

        private void sfxButton_Click(object sender, EventArgs e)
        {
            if (sfxMuted == false)
            {
                sfxMuted = true;
                sfxButton1.BackgroundImage = global::Tetris.Properties.Resources.sfxMuted;
                sfxButton2.BackgroundImage = global::Tetris.Properties.Resources.sfxMuted;
                sfxButton3.BackgroundImage = global::Tetris.Properties.Resources.sfxMuted;
            }
            else
            {
                sfxMuted = false;
                sfxButton1.BackgroundImage = global::Tetris.Properties.Resources.sfx;
                sfxButton2.BackgroundImage = global::Tetris.Properties.Resources.sfx;
                sfxButton3.BackgroundImage = global::Tetris.Properties.Resources.sfx;
            }
        }
    }
}
