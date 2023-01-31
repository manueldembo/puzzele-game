namespace PuzzeleGame
{
    partial class frmGameOver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOver));
            this.cmd_menu_inicial = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_menu_inicial)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_menu_inicial
            // 
            this.cmd_menu_inicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_menu_inicial.Location = new System.Drawing.Point(140, 223);
            this.cmd_menu_inicial.Name = "cmd_menu_inicial";
            this.cmd_menu_inicial.Size = new System.Drawing.Size(120, 50);
            this.cmd_menu_inicial.TabIndex = 6;
            this.cmd_menu_inicial.TabStop = false;
            this.cmd_menu_inicial.Click += new System.EventHandler(this.cmd_menu_inicial_Click);
            this.cmd_menu_inicial.MouseEnter += new System.EventHandler(this.cmd_menu_inicial_MouseEnter);
            this.cmd_menu_inicial.MouseLeave += new System.EventHandler(this.cmd_menu_inicial_MouseLeave);
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.cmd_menu_inicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGameOver";
            this.Load += new System.EventHandler(this.frmGameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmd_menu_inicial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cmd_menu_inicial;
    }
}