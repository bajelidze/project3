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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.checkSurePanel = new System.Windows.Forms.Panel();
            this.sureYesLabel = new System.Windows.Forms.Label();
            this.sureNoLabel = new System.Windows.Forms.Label();
            this.checkSureLabel = new System.Windows.Forms.Label();
            this.mainMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new Tetris.Custom();
            this.helpButton = new Tetris.Custom();
            this.scoresButton = new Tetris.Custom();
            this.playButton = new Tetris.Custom();
            this.playPanel = new System.Windows.Forms.Panel();
            this.mainMenuPanel.SuspendLayout();
            this.checkSurePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.playPanel);
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
            this.sureYesLabel.MouseEnter += new System.EventHandler(this.sureYesLabel_MouseEnter);
            this.sureYesLabel.MouseLeave += new System.EventHandler(this.sureYesNoLabel_MouseLeave);
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
            this.sureNoLabel.MouseEnter += new System.EventHandler(this.sureNoLabel_MouseEnter);
            this.sureNoLabel.MouseLeave += new System.EventHandler(this.sureYesNoLabel_MouseLeave);
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
            // mainMenuPictureBox
            // 
            this.mainMenuPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuPictureBox.Image = global::Tetris.Properties.Resources.Webp_net_gifmaker;
            this.mainMenuPictureBox.InitialImage = null;
            this.mainMenuPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPictureBox.Name = "mainMenuPictureBox";
            this.mainMenuPictureBox.Size = new System.Drawing.Size(550, 550);
            this.mainMenuPictureBox.TabIndex = 0;
            this.mainMenuPictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::Tetris.Properties.Resources.exit;
            this.exitButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 14F);
            this.exitButton.Location = new System.Drawing.Point(425, 450);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 100);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "QUIT";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // helpButton
            // 
            this.helpButton.BackgroundImage = global::Tetris.Properties.Resources.notSelected1;
            this.helpButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 20F);
            this.helpButton.Location = new System.Drawing.Point(175, 425);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(200, 125);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "HELP";
            this.helpButton.MouseEnter += new System.EventHandler(this.mainMenuButtons_MouseEnter);
            this.helpButton.MouseLeave += new System.EventHandler(this.mainMenuButtons_MouseLeave);
            // 
            // scoresButton
            // 
            this.scoresButton.BackgroundImage = global::Tetris.Properties.Resources.notSelected1;
            this.scoresButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 19F);
            this.scoresButton.Location = new System.Drawing.Point(175, 300);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(200, 125);
            this.scoresButton.TabIndex = 2;
            this.scoresButton.Text = "SCORES";
            this.scoresButton.MouseEnter += new System.EventHandler(this.mainMenuButtons_MouseEnter);
            this.scoresButton.MouseLeave += new System.EventHandler(this.mainMenuButtons_MouseLeave);
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::Tetris.Properties.Resources.notSelected1;
            this.playButton.Font = new System.Drawing.Font("Ode to Idle Gaming", 20F);
            this.playButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playButton.Location = new System.Drawing.Point(175, 175);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(200, 125);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "PLAY";
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.mainMenuButtons_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.mainMenuButtons_MouseLeave);
            // 
            // playPanel
            // 
            this.playPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playPanel.Location = new System.Drawing.Point(0, 0);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(550, 550);
            this.playPanel.TabIndex = 4;
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
            this.checkSurePanel.ResumeLayout(false);
            this.checkSurePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).EndInit();
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
        private System.Windows.Forms.Panel playPanel;
    }
}

