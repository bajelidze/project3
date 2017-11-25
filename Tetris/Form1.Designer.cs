using System.Drawing;

namespace Tetris
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.playMenuPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.menuButton = new Tetris.Custom();
            this.sfxButton3 = new Tetris.Custom();
            this.musicButton3 = new Tetris.Custom();
            this.musicButton2 = new Tetris.Custom();
            this.sfxButton2 = new Tetris.Custom();
            this.backButton = new Tetris.Custom();
            this.loadGameButton = new Tetris.Custom();
            this.newGameButton = new Tetris.Custom();
            this.musicButton1 = new Tetris.Custom();
            this.sfxButton1 = new Tetris.Custom();
            this.checkSurePanel = new System.Windows.Forms.Panel();
            this.sureYesLabel = new System.Windows.Forms.Label();
            this.sureNoLabel = new System.Windows.Forms.Label();
            this.checkSureLabel = new System.Windows.Forms.Label();
            this.exitButton = new Tetris.Custom();
            this.helpButton = new Tetris.Custom();
            this.scoresButton = new Tetris.Custom();
            this.playButton = new Tetris.Custom();
            this.mainMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuPanel.SuspendLayout();
            this.playMenuPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.checkSurePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.playMenuPanel);
            this.mainMenuPanel.Controls.Add(this.musicButton1);
            this.mainMenuPanel.Controls.Add(this.sfxButton1);
            this.mainMenuPanel.Controls.Add(this.checkSurePanel);
            this.mainMenuPanel.Controls.Add(this.exitButton);
            this.mainMenuPanel.Controls.Add(this.helpButton);
            this.mainMenuPanel.Controls.Add(this.scoresButton);
            this.mainMenuPanel.Controls.Add(this.playButton);
            this.mainMenuPanel.Controls.Add(this.mainMenuPictureBox);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(550, 550);
            this.mainMenuPanel.TabIndex = 1;
            // 
            // playMenuPanel
            // 
            this.playMenuPanel.BackgroundImage = global::Tetris.Properties.Resources.playMenu;
            this.playMenuPanel.Controls.Add(this.gamePanel);
            this.playMenuPanel.Controls.Add(this.musicButton2);
            this.playMenuPanel.Controls.Add(this.sfxButton2);
            this.playMenuPanel.Controls.Add(this.backButton);
            this.playMenuPanel.Controls.Add(this.loadGameButton);
            this.playMenuPanel.Controls.Add(this.newGameButton);
            this.playMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playMenuPanel.Enabled = false;
            this.playMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.playMenuPanel.Name = "playMenuPanel";
            this.playMenuPanel.Size = new System.Drawing.Size(550, 550);
            this.playMenuPanel.TabIndex = 4;
            this.playMenuPanel.Visible = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackgroundImage = global::Tetris.Properties.Resources.gameTexture;
            this.gamePanel.Controls.Add(this.menuButton);
            this.gamePanel.Controls.Add(this.sfxButton3);
            this.gamePanel.Controls.Add(this.musicButton3);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Enabled = false;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(550, 550);
            this.gamePanel.TabIndex = 6;
            this.gamePanel.Visible = false;
            // 
            // menuButton
            // 
            this.menuButton.BackgroundImage = global::Tetris.Properties.Resources.menuButton;
            this.menuButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 18F);
            this.menuButton.Location = new System.Drawing.Point(325, 425);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(175, 125);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "PAUSE";
            this.menuButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // sfxButton3
            // 
            this.sfxButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sfxButton3.Location = new System.Drawing.Point(500, 500);
            this.sfxButton3.Name = "sfxButton3";
            this.sfxButton3.Size = new System.Drawing.Size(50, 50);
            this.sfxButton3.TabIndex = 6;
            this.sfxButton3.TabStop = false;
            this.sfxButton3.Click += new System.EventHandler(this.sfxButton_Click);
            // 
            // musicButton3
            // 
            this.musicButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musicButton3.Location = new System.Drawing.Point(500, 450);
            this.musicButton3.Name = "musicButton3";
            this.musicButton3.Size = new System.Drawing.Size(50, 50);
            this.musicButton3.TabIndex = 6;
            this.musicButton3.TabStop = false;
            this.musicButton3.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // musicButton2
            // 
            this.musicButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musicButton2.Location = new System.Drawing.Point(500, 450);
            this.musicButton2.Name = "musicButton2";
            this.musicButton2.Size = new System.Drawing.Size(50, 50);
            this.musicButton2.TabIndex = 4;
            this.musicButton2.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // sfxButton2
            // 
            this.sfxButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sfxButton2.Location = new System.Drawing.Point(500, 500);
            this.sfxButton2.Name = "sfxButton2";
            this.sfxButton2.Size = new System.Drawing.Size(50, 50);
            this.sfxButton2.TabIndex = 5;
            this.sfxButton2.Click += new System.EventHandler(this.sfxButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::Tetris.Properties.Resources.notSelected;
            this.backButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 20F);
            this.backButton.Location = new System.Drawing.Point(175, 425);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 125);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "BACK";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // loadGameButton
            // 
            this.loadGameButton.BackgroundImage = global::Tetris.Properties.Resources.notSelected;
            this.loadGameButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 14F);
            this.loadGameButton.Location = new System.Drawing.Point(175, 300);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(200, 125);
            this.loadGameButton.TabIndex = 2;
            this.loadGameButton.Text = "LOAD GAME";
            this.loadGameButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.loadGameButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // newGameButton
            // 
            this.newGameButton.BackgroundImage = global::Tetris.Properties.Resources.notSelected;
            this.newGameButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 14F);
            this.newGameButton.Location = new System.Drawing.Point(175, 175);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(200, 125);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "NEW GAME";
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            this.newGameButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.newGameButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // musicButton1
            // 
            this.musicButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musicButton1.Location = new System.Drawing.Point(500, 450);
            this.musicButton1.Name = "musicButton1";
            this.musicButton1.Size = new System.Drawing.Size(50, 50);
            this.musicButton1.TabIndex = 4;
            this.musicButton1.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // sfxButton1
            // 
            this.sfxButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sfxButton1.Location = new System.Drawing.Point(500, 500);
            this.sfxButton1.Name = "sfxButton1";
            this.sfxButton1.Size = new System.Drawing.Size(50, 50);
            this.sfxButton1.TabIndex = 5;
            this.sfxButton1.Click += new System.EventHandler(this.sfxButton_Click);
            // 
            // checkSurePanel
            // 
            this.checkSurePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.checkSurePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkSurePanel.Controls.Add(this.sureYesLabel);
            this.checkSurePanel.Controls.Add(this.sureNoLabel);
            this.checkSurePanel.Controls.Add(this.checkSureLabel);
            this.checkSurePanel.Enabled = false;
            this.checkSurePanel.Location = new System.Drawing.Point(100, 190);
            this.checkSurePanel.Name = "checkSurePanel";
            this.checkSurePanel.Size = new System.Drawing.Size(350, 150);
            this.checkSurePanel.TabIndex = 0;
            this.checkSurePanel.Visible = false;
            // 
            // sureYesLabel
            // 
            this.sureYesLabel.AutoSize = true;
            this.sureYesLabel.Font = new System.Drawing.Font("Ode to Idle Gaming", 18F);
            this.sureYesLabel.ForeColor = System.Drawing.Color.DimGray;
            this.sureYesLabel.Location = new System.Drawing.Point(67, 87);
            this.sureYesLabel.Name = "sureYesLabel";
            this.sureYesLabel.Size = new System.Drawing.Size(81, 42);
            this.sureYesLabel.TabIndex = 1;
            this.sureYesLabel.Text = "YES";
            this.sureYesLabel.Click += new System.EventHandler(this.sureYesLabel_Click);
            this.sureYesLabel.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.sureYesLabel.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // sureNoLabel
            // 
            this.sureNoLabel.AutoSize = true;
            this.sureNoLabel.Font = new System.Drawing.Font("Ode to Idle Gaming", 18F);
            this.sureNoLabel.ForeColor = System.Drawing.Color.DimGray;
            this.sureNoLabel.Location = new System.Drawing.Point(210, 87);
            this.sureNoLabel.Name = "sureNoLabel";
            this.sureNoLabel.Size = new System.Drawing.Size(60, 42);
            this.sureNoLabel.TabIndex = 2;
            this.sureNoLabel.Text = "NO";
            this.sureNoLabel.Click += new System.EventHandler(this.sureNoLabel_Click);
            this.sureNoLabel.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.sureNoLabel.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // checkSureLabel
            // 
            this.checkSureLabel.AutoSize = true;
            this.checkSureLabel.Font = new System.Drawing.Font("Ode to Idle Gaming", 20F);
            this.checkSureLabel.ForeColor = System.Drawing.Color.DimGray;
            this.checkSureLabel.Location = new System.Drawing.Point(25, 15);
            this.checkSureLabel.Name = "checkSureLabel";
            this.checkSureLabel.Size = new System.Drawing.Size(304, 47);
            this.checkSureLabel.TabIndex = 0;
            this.checkSureLabel.Text = "Are you sure?";
            this.checkSureLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::Tetris.Properties.Resources.exit;
            this.exitButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 14F);
            this.exitButton.Location = new System.Drawing.Point(0, 450);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 100);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "QUIT";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // helpButton
            // 
            this.helpButton.BackgroundImage = global::Tetris.Properties.Resources.notSelected;
            this.helpButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 20F);
            this.helpButton.Location = new System.Drawing.Point(175, 425);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(200, 125);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "HELP";
            this.helpButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.helpButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // scoresButton
            // 
            this.scoresButton.BackgroundImage = global::Tetris.Properties.Resources.notSelected;
            this.scoresButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 19F);
            this.scoresButton.Location = new System.Drawing.Point(175, 300);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(200, 125);
            this.scoresButton.TabIndex = 2;
            this.scoresButton.Text = "SCORES";
            this.scoresButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.scoresButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::Tetris.Properties.Resources.notSelected;
            this.playButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 20F);
            this.playButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playButton.Location = new System.Drawing.Point(175, 175);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(200, 125);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "PLAY";
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // mainMenuPictureBox
            // 
            this.mainMenuPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuPictureBox.Image = global::Tetris.Properties.Resources.tetrisAnimated;
            this.mainMenuPictureBox.InitialImage = null;
            this.mainMenuPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPictureBox.Name = "mainMenuPictureBox";
            this.mainMenuPictureBox.Size = new System.Drawing.Size(550, 550);
            this.mainMenuPictureBox.TabIndex = 0;
            this.mainMenuPictureBox.TabStop = false;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataSource = typeof(Tetris.Game);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.mainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenuPanel.ResumeLayout(false);
            this.playMenuPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.checkSurePanel.ResumeLayout(false);
            this.checkSurePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.PictureBox mainMenuPictureBox;
        private Custom helpButton;
        private Custom scoresButton;
        private Custom exitButton;
        private Custom playButton;
        private System.Windows.Forms.Panel checkSurePanel;
        private System.Windows.Forms.Label checkSureLabel;
        private System.Windows.Forms.Label sureNoLabel;
        private System.Windows.Forms.Label sureYesLabel;
        private System.Windows.Forms.Panel playMenuPanel;
        private Custom newGameButton;
        private Custom backButton;
        private Custom loadGameButton;
        private Custom musicButton2;
        private Custom sfxButton2;
        private Custom musicButton1;
        private Custom sfxButton1;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private Custom sfxButton3;
        private Custom musicButton3;
        private Custom menuButton;
    }
}

