namespace PuzzeleGame
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pic_imagem = new System.Windows.Forms.PictureBox();
            this.cmd_esquerda = new System.Windows.Forms.PictureBox();
            this.cmd_direita = new System.Windows.Forms.PictureBox();
            this.cmd_sair = new System.Windows.Forms.PictureBox();
            this.cmd_iniciar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_esquerda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_direita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_iniciar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_imagem
            // 
            this.pic_imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_imagem.Location = new System.Drawing.Point(154, 112);
            this.pic_imagem.Name = "pic_imagem";
            this.pic_imagem.Size = new System.Drawing.Size(200, 200);
            this.pic_imagem.TabIndex = 0;
            this.pic_imagem.TabStop = false;
            // 
            // cmd_esquerda
            // 
            this.cmd_esquerda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_esquerda.Location = new System.Drawing.Point(83, 175);
            this.cmd_esquerda.Name = "cmd_esquerda";
            this.cmd_esquerda.Size = new System.Drawing.Size(60, 80);
            this.cmd_esquerda.TabIndex = 3;
            this.cmd_esquerda.TabStop = false;
            this.cmd_esquerda.Click += new System.EventHandler(this.cmd_esquerda_Click);
            this.cmd_esquerda.MouseEnter += new System.EventHandler(this.cmd_esquerda_MouseEnter);
            this.cmd_esquerda.MouseLeave += new System.EventHandler(this.cmd_esquerda_MouseLeave);
            // 
            // cmd_direita
            // 
            this.cmd_direita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_direita.Location = new System.Drawing.Point(365, 175);
            this.cmd_direita.Name = "cmd_direita";
            this.cmd_direita.Size = new System.Drawing.Size(60, 80);
            this.cmd_direita.TabIndex = 4;
            this.cmd_direita.TabStop = false;
            this.cmd_direita.Click += new System.EventHandler(this.cmd_direita_Click);
            this.cmd_direita.MouseEnter += new System.EventHandler(this.cmd_direita_MouseEnter);
            this.cmd_direita.MouseLeave += new System.EventHandler(this.cmd_direita_MouseLeave);
            // 
            // cmd_sair
            // 
            this.cmd_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_sair.Location = new System.Drawing.Point(88, 346);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(120, 50);
            this.cmd_sair.TabIndex = 5;
            this.cmd_sair.TabStop = false;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            this.cmd_sair.MouseEnter += new System.EventHandler(this.cmd_sair_MouseEnter);
            this.cmd_sair.MouseLeave += new System.EventHandler(this.cmd_sair_MouseLeave);
            // 
            // cmd_iniciar
            // 
            this.cmd_iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_iniciar.Location = new System.Drawing.Point(299, 346);
            this.cmd_iniciar.Name = "cmd_iniciar";
            this.cmd_iniciar.Size = new System.Drawing.Size(120, 50);
            this.cmd_iniciar.TabIndex = 6;
            this.cmd_iniciar.TabStop = false;
            this.cmd_iniciar.Click += new System.EventHandler(this.cmd_iniciar_Click);
            this.cmd_iniciar.MouseEnter += new System.EventHandler(this.cmd_iniciar_MouseEnter);
            this.cmd_iniciar.MouseLeave += new System.EventHandler(this.cmd_iniciar_MouseLeave);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.cmd_iniciar);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_direita);
            this.Controls.Add(this.cmd_esquerda);
            this.Controls.Add(this.pic_imagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_esquerda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_direita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_iniciar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_imagem;
        private System.Windows.Forms.PictureBox cmd_esquerda;
        private System.Windows.Forms.PictureBox cmd_direita;
        private System.Windows.Forms.PictureBox cmd_sair;
        private System.Windows.Forms.PictureBox cmd_iniciar;
    }
}