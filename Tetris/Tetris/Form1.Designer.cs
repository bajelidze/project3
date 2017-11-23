namespace Tetris
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.custom4 = new Tetris.Custom();
            this.custom3 = new Tetris.Custom();
            this.custom2 = new Tetris.Custom();
            this.play = new Tetris.Custom();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 26);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // custom4
            // 
            this.custom4.BackColor = System.Drawing.Color.Blue;
            this.custom4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("custom4.BackgroundImage")));
            this.custom4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.custom4.Location = new System.Drawing.Point(122, 473);
            this.custom4.Name = "custom4";
            this.custom4.Size = new System.Drawing.Size(265, 119);
            this.custom4.TabIndex = 4;
            this.custom4.Text = "adsdsadsa";
            this.custom4.MouseEnter += new System.EventHandler(this.custom_Enter);
            this.custom4.MouseLeave += new System.EventHandler(this.custom_MouseLeave);
            // 
            // custom3
            // 
            this.custom3.BackColor = System.Drawing.Color.Blue;
            this.custom3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("custom3.BackgroundImage")));
            this.custom3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.custom3.Location = new System.Drawing.Point(122, 355);
            this.custom3.Name = "custom3";
            this.custom3.Size = new System.Drawing.Size(265, 119);
            this.custom3.TabIndex = 3;
            this.custom3.Text = "adsdsadsa";
            this.custom3.MouseEnter += new System.EventHandler(this.custom_Enter);
            this.custom3.MouseLeave += new System.EventHandler(this.custom_MouseLeave);
            // 
            // custom2
            // 
            this.custom2.BackColor = System.Drawing.Color.Blue;
            this.custom2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("custom2.BackgroundImage")));
            this.custom2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.custom2.Cursor = System.Windows.Forms.Cursors.Default;
            this.custom2.Location = new System.Drawing.Point(122, 236);
            this.custom2.Name = "custom2";
            this.custom2.Size = new System.Drawing.Size(265, 119);
            this.custom2.TabIndex = 2;
            this.custom2.Text = "adsdsadsa";
            this.custom2.MouseEnter += new System.EventHandler(this.custom_Enter);
            this.custom2.MouseLeave += new System.EventHandler(this.custom_MouseLeave);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Blue;
            this.play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play.BackgroundImage")));
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.ForeColor = System.Drawing.SystemColors.ControlText;
            this.play.Location = new System.Drawing.Point(122, 118);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(265, 119);
            this.play.TabIndex = 1;
            this.play.Text = "adsdsadsa";
            this.play.Click += new System.EventHandler(this.play_Click);
            this.play.MouseEnter += new System.EventHandler(this.custom_Enter);
            this.play.MouseLeave += new System.EventHandler(this.custom_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Tetris.Properties.Resources.mainmenu4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 611);
            this.Controls.Add(this.custom4);
            this.Controls.Add(this.custom3);
            this.Controls.Add(this.custom2);
            this.Controls.Add(this.play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Custom custom4;
        private Custom custom3;
        private Custom custom2;
        private Custom play;
    }
}

