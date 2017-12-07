using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using Newtonsoft.Json;
using System.IO;

namespace Tetris
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Game Game = new Game();

        SoundPlayer theme = new SoundPlayer();

        PictureBox[,] nextPiece = new PictureBox[4, 4];
        PictureBox[,] board = new PictureBox[18, 10];

        string[,] highScores = new string[10, 2];
        Label[,] highScoresLabels = new Label[10, 2];

        int timer2Time = 3;
        int n;

        bool paused = false;
        bool gameOver = false;
        bool highScore = false;
        bool musicMuted = false;
        public static bool sfxMuted = false;

        public Form1()
        {
            InitializeComponent();

            linesLabel2.Text = Game.lines.ToString();
            levelLabel2.Text = Game.level.ToString();

            try
            {
                highScores = JsonConvert.DeserializeObject<string[,]>(File.ReadAllText(Environment.CurrentDirectory + @"\JsonFiles\Save\HighScores.json"));
                musicMuted = JsonConvert.DeserializeObject<bool>(File.ReadAllText(Environment.CurrentDirectory + @"\JsonFiles\musicMuted.json"));
                sfxMuted = JsonConvert.DeserializeObject<bool>(File.ReadAllText(Environment.CurrentDirectory + @"\JsonFiles\sfxMuted.json"));
            }
            catch
            {
                File.WriteAllText(Environment.CurrentDirectory + @"\JsonFiles\Save\HighScores.json", JsonConvert.SerializeObject(highScores));
                File.WriteAllText(Environment.CurrentDirectory + @"\JsonFiles\Save\musicMuted.json", JsonConvert.SerializeObject(musicMuted));
                File.WriteAllText(Environment.CurrentDirectory + @"\JsonFiles\Save\sfxMuted.json", JsonConvert.SerializeObject(sfxMuted));
            }

            SetupScores();

            try
            {
                theme.SoundLocation = Environment.CurrentDirectory + @"\sound\theme1.wav";
                Game.rotationSound.SoundLocation = Environment.CurrentDirectory + @"\sound\rotation.wav";
                Game.stopSound.SoundLocation = Environment.CurrentDirectory + @"\sound\stop.wav";
                Game.clearSound.SoundLocation = Environment.CurrentDirectory + @"\sound\clear.wav";
                Game.loss.SoundLocation = Environment.CurrentDirectory + @"\sound\loss.wav";
            }
            catch { }

            if (musicMuted == true)
            {
                musicButton1.BackgroundImage = Tetris.Properties.Resources.musicMuted;
                musicButton2.BackgroundImage = Tetris.Properties.Resources.musicMuted;
                musicButton3.BackgroundImage = Tetris.Properties.Resources.musicMuted;
            }
            else
            {
                theme.PlayLooping();
                musicButton1.BackgroundImage = Tetris.Properties.Resources.music;
                musicButton2.BackgroundImage = Tetris.Properties.Resources.music;
                musicButton3.BackgroundImage = Tetris.Properties.Resources.music;
            }

            if (sfxMuted == true)
            {
                sfxButton1.BackgroundImage = Tetris.Properties.Resources.sfxMuted;
                sfxButton2.BackgroundImage = Tetris.Properties.Resources.sfxMuted;
                sfxButton3.BackgroundImage = Tetris.Properties.Resources.sfxMuted;
            }
            else
            {
                sfxButton1.BackgroundImage = Tetris.Properties.Resources.sfx;
                sfxButton2.BackgroundImage = Tetris.Properties.Resources.sfx;
                sfxButton3.BackgroundImage = Tetris.Properties.Resources.sfx;
            }

            SetupBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            if (sender == pauseButton)
            {
                pauseButton.BackgroundImage = Properties.Resources.menuButtonSelected;
                pauseButton.textBrush = new SolidBrush(Color.Green);
            }
            else if (sender == exitButton)
            {
                exitButton.BackgroundImage = Properties.Resources.exitSelected;
                exitButton.textBrush = new SolidBrush(Color.DarkRed);
            }
            else if (sender == backButton2 || sender == backButton3)
            {
                ((Custom)sender).BackgroundImage = Properties.Resources.backSelected;
                ((Custom)sender).textBrush = new SolidBrush(Color.Green);
            }
            else if (sender == sureYesLabel || sender == pauseResumeLabel || sender == hsResumeLabel)
            {
                ((Label)sender).ForeColor = Color.Green;
            }
            else if (sender == sureNoLabel || sender == pauseQuitLabel || sender == hsQuitLabel)
            {
                ((Label)sender).ForeColor = Color.Red;
            }
            else
            {
                ((Custom)sender).BackgroundImage = Properties.Resources.selected;
                ((Custom)sender).textBrush = new SolidBrush(Color.Green);
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            if (sender == pauseButton)
            {
                pauseButton.BackgroundImage = Properties.Resources.menuButton;
                pauseButton.textBrush = new SolidBrush(Color.DimGray);
            }
            else if (sender == exitButton)
            {
                exitButton.BackgroundImage = Properties.Resources.exit;
                exitButton.textBrush = new SolidBrush(Color.DimGray);
            }
            else if (sender == backButton2 || sender == backButton3)
            {
                ((Custom)sender).BackgroundImage = Properties.Resources.back;
                ((Custom)sender).textBrush = new SolidBrush(Color.DimGray);
            }
            else if (sender == sureYesLabel || sender == pauseResumeLabel || sender == pauseQuitLabel || sender == sureNoLabel
                  || sender == hsResumeLabel || sender == hsQuitLabel)
            {
                ((Label)sender).ForeColor = Color.DimGray;
            }
            else
            {
                ((Custom)sender).BackgroundImage = Properties.Resources.notSelected;
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

        private void playButton_Click(object sender, EventArgs e)
        {
            playMenuPanel.Enabled = true;
            playMenuPanel.Visible = true;
            foreach (Control c in playMenuPanel.Controls)
            {
                if (c is Panel)
                {
                    continue;
                }
                c.Enabled = true;
                c.Visible = true;
            }

            foreach (Control c in mainMenuPanel.Controls)
            {
                if (c is Panel)
                {
                    continue;
                }
                c.Enabled = false;
                c.Visible = false;
            }

            pauseButton.Enabled = false;
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
            Game.StartOver();
            timer2Time = 3;
            timer.Interval = 500;
            timeLabel.Text = timer2Time.ToString();
            scoreLabel2.Text = Game.score.ToString();
            levelLabel2.Text = Game.level.ToString();
            linesLabel2.Text = Game.lines.ToString();
            theme.Stop();
            musicButton3.BackgroundImage = Tetris.Properties.Resources.musicMuted;

            Game.RandomizeNextPiece();
            Game.AddNewPiece();
            RenderBoard();

            Game.RandomizeNextPiece();
            RenderNextPiece();

            foreach (Control c in playMenuPanel.Controls)
            {
                c.Visible = false;
                c.Enabled = false;
            }

            pausePanel.Visible = false;
            pausePanel.Enabled = false;

            gamePanel.Visible = true;
            gamePanel.Enabled = true;

            timePanel.Visible = true;
            timePanel.Enabled = true;
            timeLabel.Visible = true;
            timeLabel.Enabled = true;

            timer2.Enabled = true;
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                Game.LoadGame();
            }
            catch { }

            try
            {
                timer.Interval = JsonConvert.DeserializeObject<int>(File.ReadAllText(Environment.CurrentDirectory + @"\JsonFiles\Save\timer.json"));
            }
            catch
            {
                File.WriteAllText(Environment.CurrentDirectory + @"\JsonFiles\Save\timer.json", JsonConvert.SerializeObject(timer.Interval));
            }

            timer2Time = 3;
            timeLabel.Text = timer2Time.ToString();
            scoreLabel2.Text = Game.score.ToString();
            levelLabel2.Text = Game.level.ToString();
            linesLabel2.Text = Game.lines.ToString();
            theme.Stop();
            musicButton3.BackgroundImage = Tetris.Properties.Resources.musicMuted;

            RenderBoard();

            RenderNextPiece();

            foreach (Control c in playMenuPanel.Controls)
            {
                c.Visible = false;
                c.Enabled = false;
            }

            pausePanel.Visible = false;
            pausePanel.Enabled = false;

            gamePanel.Visible = true;
            gamePanel.Enabled = true;

            timePanel.Visible = true;
            timePanel.Enabled = true;
            timeLabel.Visible = true;
            timeLabel.Enabled = true;

            timer2.Enabled = true;
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            if (musicMuted == false)
            {
                musicMuted = true;

                musicButton1.BackgroundImage = Tetris.Properties.Resources.musicMuted;
                musicButton2.BackgroundImage = Tetris.Properties.Resources.musicMuted;
                musicButton3.BackgroundImage = Tetris.Properties.Resources.musicMuted;
                theme.Stop();
            }
            else
            {
                musicMuted = false;

                musicButton1.BackgroundImage = Tetris.Properties.Resources.music;
                musicButton2.BackgroundImage = Tetris.Properties.Resources.music;
                musicButton3.BackgroundImage = Tetris.Properties.Resources.music;

                theme.PlayLooping();
            }

            File.WriteAllText(Environment.CurrentDirectory + @"\JsonFiles\musicMuted.json", JsonConvert.SerializeObject(musicMuted));
        }

        private void sfxButton_Click(object sender, EventArgs e)
        {
            if (sfxMuted == false)
            {
                sfxMuted = true;

                sfxButton1.BackgroundImage = Tetris.Properties.Resources.sfxMuted;
                sfxButton2.BackgroundImage = Tetris.Properties.Resources.sfxMuted;
                sfxButton3.BackgroundImage = Tetris.Properties.Resources.sfxMuted;
            }
            else
            {
                sfxMuted = false;

                sfxButton1.BackgroundImage = Tetris.Properties.Resources.sfx;
                sfxButton2.BackgroundImage = Tetris.Properties.Resources.sfx;
                sfxButton3.BackgroundImage = Tetris.Properties.Resources.sfx;
            }

            File.WriteAllText(Environment.CurrentDirectory + @"\JsonFiles\sfxMuted.json", JsonConvert.SerializeObject(sfxMuted));
        }

        private void pauseResumeLabel_Click(object sender, EventArgs e)
        {

            if (gameOver == false)
            {
                timer.Start();
                pausePanel.Visible = false;
                pausePanel.Enabled = false;

                foreach (Control c in gamePanel.Controls)
                {
                    c.Enabled = true;
                }
            }
            else
            {
                newGameButton_Click(null, null);
            }

            gameOver = false;
            paused = false;

            if (highScore == true)
            {
                hsPanel.Enabled = false;
                hsPanel.Visible = false;
                highScore = false;

                highScores[n, 0] = nameTextBox.Text;
                if (nameTextBox.Text == null || nameTextBox.Text == "")
                {
                    highScores[n, 0] = "Player";
                }
                highScoresLabels[n, 0].Text = highScores[n, 0];
                highScoresLabels[n, 1].Text = highScores[n, 1];
                nameTextBox.Text = null;

                File.WriteAllText(Environment.CurrentDirectory + @"\JsonFiles\Save\HighScores.json", JsonConvert.SerializeObject(highScores));
            }
        }

        private void pauseQuitLabel_Click(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                Game.SaveGame();
                File.WriteAllText(Environment.CurrentDirectory + @"\JsonFiles\Save\timer.json", JsonConvert.SerializeObject(timer.Interval));
            }

            paused = false;

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
            gamePanel.Enabled = false;
            gamePanel.Visible = false;

            if (musicMuted == false)
            {
                theme.PlayLooping();
            }
            gameOver = false;

            if (highScore == true)
            {
                hsPanel.Enabled = false;
                hsPanel.Visible = false;
                highScore = false;

                highScores[n, 0] = nameTextBox.Text;
                if (nameTextBox.Text == null || nameTextBox.Text == "")
                {
                    highScores[n, 0] = "Player";
                }
                highScoresLabels[n, 0].Text = highScores[n, 0];
                highScoresLabels[n, 1].Text = highScores[n, 1];
                nameTextBox.Text = null;

                File.WriteAllText(Environment.CurrentDirectory + @"\JsonFiles\Save\HighScores.json", JsonConvert.SerializeObject(highScores));
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (timer2Time == 0)
            {
                scorePauseLabel.Text = "Score: " + Game.score.ToString();
                pauseResumeLabel.Text = "Resume";
                pauseQuitLabel.Text = "Save and Quit";
                pauseLabel.Text = "Paused";
                timer.Stop();
                paused = true;
                pausePanel.Visible = true;
                pausePanel.Enabled = true;

                foreach (Control c in gamePanel.Controls)
                {
                    if (c is Panel || c is Label || c == sfxButton3 || c == musicButton3)
                    {
                        continue;
                    }
                    c.Enabled = false;
                }
            }
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            scoresPanel.Enabled = true;
            scoresPanel.Visible = true;

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

        private void backButton2_Click(object sender, EventArgs e)
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

            scoresPanel.Enabled = false;
            scoresPanel.Visible = false;
        }

        private void backButton3_Click(object sender, EventArgs e)
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

            helpPanel.Enabled = false;
            helpPanel.Visible = false;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            helpPanel.Enabled = true;
            helpPanel.Visible = true;

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

        private void SetupScores()
        {
            highScoresLabels[0, 0] = l00; highScoresLabels[0, 1] = l01;
            highScoresLabels[1, 0] = l10; highScoresLabels[1, 1] = l11;
            highScoresLabels[2, 0] = l20; highScoresLabels[2, 1] = l21;
            highScoresLabels[3, 0] = l30; highScoresLabels[3, 1] = l31;
            highScoresLabels[4, 0] = l40; highScoresLabels[4, 1] = l41;
            highScoresLabels[5, 0] = l50; highScoresLabels[5, 1] = l51;
            highScoresLabels[6, 0] = l60; highScoresLabels[6, 1] = l61;
            highScoresLabels[7, 0] = l70; highScoresLabels[7, 1] = l71;
            highScoresLabels[8, 0] = l80; highScoresLabels[8, 1] = l81;
            highScoresLabels[9, 0] = l90; highScoresLabels[9, 1] = l91;

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    highScoresLabels[i, j].Text = highScores[i, j];
                }
            }
        }

        private void SetupBoard()
        {
            nextPiece[0, 0] = n1; nextPiece[0, 1] = n2; nextPiece[0, 2] = n3; nextPiece[0, 3] = n4;
            nextPiece[1, 0] = n5; nextPiece[1, 1] = n6; nextPiece[1, 2] = n7; nextPiece[1, 3] = n8;
            nextPiece[2, 0] = n9; nextPiece[2, 1] = n10; nextPiece[2, 2] = n11; nextPiece[2, 3] = n12;
            nextPiece[3, 0] = n13; nextPiece[3, 1] = n14; nextPiece[3, 2] = n15; nextPiece[3, 3] = n16;

            board[0, 0] = f11; board[0, 1] = f12; board[0, 2] = f13; board[0, 3] = f14; board[0, 4] = f15;
            board[0, 5] = f16; board[0, 6] = f17; board[0, 7] = f18; board[0, 8] = f19; board[0, 9] = f110;

            board[1, 0] = f21; board[1, 1] = f22; board[1, 2] = f23; board[1, 3] = f24; board[1, 4] = f25;
            board[1, 5] = f26; board[1, 6] = f27; board[1, 7] = f28; board[1, 8] = f29; board[1, 9] = f210;

            board[2, 0] = f31; board[2, 1] = f32; board[2, 2] = f33; board[2, 3] = f34; board[2, 4] = f35;
            board[2, 5] = f36; board[2, 6] = f37; board[2, 7] = f38; board[2, 8] = f39; board[2, 9] = f310;

            board[3, 0] = f41; board[3, 1] = f42; board[3, 2] = f43; board[3, 3] = f44; board[3, 4] = f45;
            board[3, 5] = f46; board[3, 6] = f47; board[3, 7] = f48; board[3, 8] = f49; board[3, 9] = f410;

            board[4, 0] = f51; board[4, 1] = f52; board[4, 2] = f53; board[4, 3] = f54; board[4, 4] = f55;
            board[4, 5] = f56; board[4, 6] = f57; board[4, 7] = f58; board[4, 8] = f59; board[4, 9] = f510;

            board[5, 0] = f61; board[5, 1] = f62; board[5, 2] = f63; board[5, 3] = f64; board[5, 4] = f65;
            board[5, 5] = f66; board[5, 6] = f67; board[5, 7] = f68; board[5, 8] = f69; board[5, 9] = f610;

            board[6, 0] = f71; board[6, 1] = f72; board[6, 2] = f73; board[6, 3] = f74; board[6, 4] = f75;
            board[6, 5] = f76; board[6, 6] = f77; board[6, 7] = f78; board[6, 8] = f79; board[6, 9] = f710;

            board[7, 0] = f81; board[7, 1] = f82; board[7, 2] = f83; board[7, 3] = f84; board[7, 4] = f85;
            board[7, 5] = f86; board[7, 6] = f87; board[7, 7] = f88; board[7, 8] = f89; board[7, 9] = f810;

            board[8, 0] = f91; board[8, 1] = f92; board[8, 2] = f93; board[8, 3] = f94; board[8, 4] = f95;
            board[8, 5] = f96; board[8, 6] = f97; board[8, 7] = f98; board[8, 8] = f99; board[8, 9] = f910;

            board[9, 0] = f101; board[9, 1] = f102; board[9, 2] = f103; board[9, 3] = f104; board[9, 4] = f105;
            board[9, 5] = f106; board[9, 6] = f107; board[9, 7] = f108; board[9, 8] = f109; board[9, 9] = f1010;

            board[10, 0] = f111; board[10, 1] = f112; board[10, 2] = f113; board[10, 3] = f114; board[10, 4] = f115;
            board[10, 5] = f116; board[10, 6] = f117; board[10, 7] = f118; board[10, 8] = f119; board[10, 9] = f1110;

            board[11, 0] = f121; board[11, 1] = f122; board[11, 2] = f123; board[11, 3] = f124; board[11, 4] = f125;
            board[11, 5] = f126; board[11, 6] = f127; board[11, 7] = f128; board[11, 8] = f129; board[11, 9] = f1210;

            board[12, 0] = f131; board[12, 1] = f132; board[12, 2] = f133; board[12, 3] = f134; board[12, 4] = f135;
            board[12, 5] = f136; board[12, 6] = f137; board[12, 7] = f138; board[12, 8] = f139; board[12, 9] = f1310;

            board[13, 0] = f141; board[13, 1] = f142; board[13, 2] = f143; board[13, 3] = f144; board[13, 4] = f145;
            board[13, 5] = f146; board[13, 6] = f147; board[13, 7] = f148; board[13, 8] = f149; board[13, 9] = f1410;

            board[14, 0] = f151; board[14, 1] = f152; board[14, 2] = f153; board[14, 3] = f154; board[14, 4] = f155;
            board[14, 5] = f156; board[14, 6] = f157; board[14, 7] = f158; board[14, 8] = f159; board[14, 9] = f1510;

            board[15, 0] = f161; board[15, 1] = f162; board[15, 2] = f163; board[15, 3] = f164; board[15, 4] = f165;
            board[15, 5] = f166; board[15, 6] = f167; board[15, 7] = f168; board[15, 8] = f169; board[15, 9] = f1610;

            board[16, 0] = f171; board[16, 1] = f172; board[16, 2] = f173; board[16, 3] = f174; board[16, 4] = f175;
            board[16, 5] = f176; board[16, 6] = f177; board[16, 7] = f178; board[16, 8] = f179; board[16, 9] = f1710;

            board[17, 0] = f181; board[17, 1] = f182; board[17, 2] = f183; board[17, 3] = f184; board[17, 4] = f185;
            board[17, 5] = f186; board[17, 6] = f187; board[17, 7] = f188; board[17, 8] = f189; board[17, 9] = f1810;
        }

        private void RenderBoard()
        {
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Game.board[i + 3, j] == 0)
                    {
                        //[i, j].BackgroundImage = null;
                        board[i, j].BackColor = Color.DarkGray;
                    }
                    else if (Game.board[i + 3, j] == 1 || (Game.board[i + 3, j] == 8 && Game.color == 1))
                    {
                        // board[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_LightBlue;
                        board[i, j].BackColor = Color.Cyan;
                    }
                    else if (Game.board[i + 3, j] == 2 || (Game.board[i + 3, j] == 8 && Game.color == 2))
                    {
                        //board[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Purple;
                        board[i, j].BackColor = Color.Purple;
                    }
                    else if (Game.board[i + 3, j] == 3 || (Game.board[i + 3, j] == 8 && Game.color == 3))
                    {
                        //board[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Orange;
                        board[i, j].BackColor = Color.Orange;
                    }
                    else if (Game.board[i + 3, j] == 4 || (Game.board[i + 3, j] == 8 && Game.color == 4))
                    {
                        //board[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Blue;
                        board[i, j].BackColor = Color.Blue;
                    }
                    else if (Game.board[i + 3, j] == 5 || (Game.board[i + 3, j] == 8 && Game.color == 5))
                    {
                        //board[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Red;
                        board[i, j].BackColor = Color.Red;
                    }
                    else if (Game.board[i + 3, j] == 6 || (Game.board[i + 3, j] == 8 && Game.color == 6))
                    {
                        //board[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Green;
                        board[i, j].BackColor = Color.Green;
                    }
                    else if (Game.board[i + 3, j] == 7 || (Game.board[i + 3, j] == 8 && Game.color == 7))
                    {
                        //board[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Yellow;
                        board[i, j].BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void RenderNextPiece()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game.nextPiece[i, j] == 0)
                    {
                        //nextPiece[i, j].BackgroundImage = null;
                        nextPiece[i, j].BackColor = Color.Transparent;
                    }
                    else if (Game.nextPiece[i, j] == 1)
                    {
                        //nextPiece[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_LightBlue;
                        nextPiece[i, j].BackColor = Color.Cyan;
                    }
                    else if (Game.nextPiece[i, j] == 2)
                    {
                        // nextPiece[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Purple;
                        nextPiece[i, j].BackColor = Color.Purple;
                    }
                    else if (Game.nextPiece[i, j] == 3)
                    {
                        //nextPiece[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Orange;
                        nextPiece[i, j].BackColor = Color.Orange;
                    }
                    else if (Game.nextPiece[i, j] == 4)
                    {
                        //nextPiece[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Blue;
                        nextPiece[i, j].BackColor = Color.Blue;
                    }
                    else if (Game.nextPiece[i, j] == 5)
                    {
                        //nextPiece[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Red;
                        nextPiece[i, j].BackColor = Color.Red;
                    }
                    else if (Game.nextPiece[i, j] == 6)
                    {
                        // nextPiece[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Green;
                        nextPiece[i, j].BackColor = Color.Green;
                    }
                    else if (Game.nextPiece[i, j] == 7)
                    {
                        //nextPiece[i, j].BackgroundImage = global::Tetris.Properties.Resources.Block_Yellow;
                        nextPiece[i, j].BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void CheckIfPieceExists()
        {
            if (Game.pieceExists == false)
            {
                if (sfxMuted == false)
                {
                    Game.stopSound.Play();
                }

                for (int r = 0; r < 21; r++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        if (Game.board[r, c] == 9 || Game.board[r, c] == 8)
                        {
                            Game.board[r, c] = Game.color;
                        }
                    }
                }

                if (Game.RemoveFullColumns() == true)
                {
                    if (levelLabel2.Text != Game.level.ToString())
                    {
                        levelLabel2.Text = Game.level.ToString();
                        timer.Stop();
                        try
                        {
                            timer.Interval = (timer.Interval * 3) / 4;
                        }
                        catch { }
                        timer.Start();
                    }
                    scoreLabel2.Text = Game.score.ToString();
                    linesLabel2.Text = Game.lines.ToString();
                }

                if (Game.AddNewPiece() == false)
                {
                    for (n = 0; n < 10; n++)
                    {
                        if (highScores[n, 1] == null)
                        {
                            highScore = true;
                            highScores[n, 1] = Game.score.ToString();
                            break;
                        }
                        else if (Convert.ToInt32(highScores[n, 1]) < Game.score)
                        {
                            highScore = true;
                            for (int j = 9; j > n; j--)
                            {
                                highScores[j, 1] = highScores[j - 1, 1];
                                highScores[j, 0] = highScores[j - 1, 0];
                                highScoresLabels[j, 1].Text = highScores[j, 1];
                                highScoresLabels[j, 0].Text = highScores[j, 0];
                            }
                            highScores[n, 1] = Game.score.ToString();
                            break;
                        }
                    }

                    paused = true;
                    if (sfxMuted == false)
                    {
                        Game.loss.Play();
                    }

                    timer.Stop();
                    gameOver = true;

                    foreach (Control c in gamePanel.Controls)
                    {
                        if (c is Panel || c is Label || c == sfxButton3 || c == musicButton3)
                        {
                            continue;
                        }
                        c.Enabled = false;
                    }

                    if (highScore == false)
                    {
                        scorePauseLabel.Text = "Score: " + Game.score.ToString();
                        pauseResumeLabel.Text = "New Game";
                        pauseQuitLabel.Text = "Main Menu";
                        pauseLabel.Text = "Game Over";

                        pausePanel.Visible = true;
                        pausePanel.Enabled = true;
                    }
                    else
                    {
                        score2Label.Text = "Score: " + Game.score.ToString();
                        hsPanel.Visible = true;
                        hsPanel.Enabled = true;
                    }
                }

                Game.RandomizeNextPiece();
                RenderNextPiece();
                RenderBoard();

                Game.pieceExists = true;
                return;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CheckIfPieceExists();

            Game.MovePiece("down");

            RenderBoard();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2Time--;
            timeLabel.Text = timer2Time.ToString();
            if (timer2Time == 0)
            {
                timer2.Enabled = false;
                timePanel.Visible = false;
                timePanel.Enabled = false;
                pauseButton.Enabled = true;
                timer.Enabled = true;
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;  // without this windows will make ding sound every key press

            if ((e.KeyData == (Keys.Control | Keys.M)) || e.KeyData == Keys.M)
            {
                sfxButton_Click(null, null);
            }
            else if (gamePanel.Visible == true && paused == false && timer2Time == 0 && gameOver == false)
            {
                if (e.KeyData == Keys.Right || e.KeyData == Keys.D)
                {
                    CheckIfPieceExists();

                    Game.MovePiece("right");

                    RenderBoard();
                }
                else if (e.KeyData == Keys.Left || e.KeyData == Keys.A)
                {
                    CheckIfPieceExists();

                    Game.MovePiece("left");

                    RenderBoard();
                }
                else if (e.KeyData == Keys.Up || e.KeyData == Keys.W)
                {
                    Game.RotatePiece(true);

                    if (sfxMuted == false)
                    {
                        Game.rotationSound.Play();
                    }

                    RenderBoard();
                }
                else if (e.KeyData == Keys.Down || e.KeyData == Keys.S)
                {
                    Game.RotatePiece(false);

                    if (sfxMuted == false)
                    {
                        Game.rotationSound.Play();
                    }

                    RenderBoard();
                }
                else if (e.KeyData == Keys.Space)
                {
                    CheckIfPieceExists();

                    Game.MovePiece("down");

                    RenderBoard();
                }
                else if (e.KeyData == Keys.Home)
                {
                    Game.level++;

                    levelLabel2.Text = Game.level.ToString();
                    timer.Stop();
                    try
                    {
                        timer.Interval = (timer.Interval * 3) / 4;
                    }
                    catch { }
                    timer.Start();
                }
                else if ((e.KeyData == (Keys.Control | Keys.P)) || e.KeyData == Keys.P)
                {
                    pauseButton_Click(null, null);
                }
            }
            else if (gamePanel.Visible == true && paused == true)
            {
                if (gameOver == false && ((e.KeyData == (Keys.Control | Keys.P)) || e.KeyData == Keys.P || (e.KeyData == (Keys.Control | Keys.G))))
                {
                    pauseResumeLabel_Click(null, null);
                }
            }
        }
    }
}
