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
            this.custom1 = new Tetris.Custom();
            this.custom2 = new Tetris.Custom();
            this.custom3 = new Tetris.Custom();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            // custom1
            // 
            this.custom1.BorderThickness = 1F;
            this.custom1.Location = new System.Drawing.Point(112, 92);
            this.custom1.Name = "custom1";
            this.custom1.Size = new System.Drawing.Size(256, 128);
            this.custom1.TabIndex = 2;
            this.custom1.Text = "custom1";
            // 
            // custom2
            // 
            this.custom2.BorderThickness = 1F;
            this.custom2.Location = new System.Drawing.Point(112, 226);
            this.custom2.Name = "custom2";
            this.custom2.Size = new System.Drawing.Size(256, 128);
            this.custom2.TabIndex = 2;
            this.custom2.Text = "custom1";
            // 
            // custom3
            // 
            this.custom3.BorderThickness = 1F;
            this.custom3.Location = new System.Drawing.Point(112, 360);
            this.custom3.Name = "custom3";
            this.custom3.Size = new System.Drawing.Size(256, 128);
            this.custom3.TabIndex = 2;
            this.custom3.Text = "custom1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 611);
            this.Controls.Add(this.custom3);
            this.Controls.Add(this.custom2);
            this.Controls.Add(this.custom1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private Custom custom1;
        private Custom custom2;
        private Custom custom3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

