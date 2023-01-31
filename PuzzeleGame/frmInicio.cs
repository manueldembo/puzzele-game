using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PuzzeleGame
{
    //===================================================================
    //quadro de inicio
    //===================================================================
    public partial class frmInicio : Form
    {
        string[] imagens;
        int index = 0;
        string path;
        //===============================================================
        public frmInicio()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            path = Application.StartupPath +  @"\";

            //carregar imagem de início do jogo
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img_inicio.png");

            //recolher imagens existentes
            imagens = Directory.GetFiles(Application.StartupPath + @"\", "imagem_*.jpg");
            ApresentarImagem();

            //botoes
            cmd_direita.BackgroundImage = Image.FromFile(path + "cmd_dir_normal.jpg");
            cmd_esquerda.BackgroundImage = Image.FromFile(path + "cmd_esq_normal.jpg");
            cmd_sair.BackgroundImage = Image.FromFile(path + "cmd_sair_normal.jpg");
            cmd_iniciar.BackgroundImage = Image.FromFile(path + "cmd_inicio_normal.jpg");
        }

        //===============================================================
        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        //===============================================================
        private void ApresentarImagem()
        { 
            //apresentar imagens
            pic_imagem.BackgroundImage = Image.FromFile(imagens[index]);
        }

        //===============================================================
        private void cmd_esquerda_Click(object sender, EventArgs e)
        {
            //altera a imagem esquerda
            if (index == 0)
                index = imagens.Length - 1;
            else
                index--;

            ApresentarImagem();
        }

        //===============================================================
        private void cmd_direita_Click(object sender, EventArgs e)
        {
            //altera a imagem esquerda
            if (index == imagens.Length - 1)
                index = 0;
            else
                index++;

            ApresentarImagem();
        }

        //===============================================================
        private void cmd_esquerda_MouseEnter(object sender, EventArgs e)
        {
            cmd_esquerda.BackgroundImage = Image.FromFile(path + "cmd_esq_high.jpg");
        }

        //===============================================================
        private void cmd_direita_MouseEnter(object sender, EventArgs e)
        {
            cmd_direita.BackgroundImage = Image.FromFile(path + "cmd_dir_high.jpg");
        }

        //===============================================================
        private void cmd_esquerda_MouseLeave(object sender, EventArgs e)
        {
            cmd_esquerda.BackgroundImage = Image.FromFile(path + "cmd_esq_normal.jpg");
        }

        //===============================================================
        private void cmd_direita_MouseLeave(object sender, EventArgs e)
        {
            cmd_direita.BackgroundImage = Image.FromFile(path + "cmd_dir_normal.jpg");
        }

        //===============================================================
        private void cmd_sair_MouseEnter(object sender, EventArgs e)
        {
            cmd_sair.BackgroundImage = Image.FromFile(path + "cmd_sair_high.jpg");
        }

        //===============================================================
        private void cmd_sair_MouseLeave(object sender, EventArgs e)
        {
            cmd_sair.BackgroundImage = Image.FromFile(path + "cmd_sair_normal.jpg");
        }

        //===============================================================
        private void cmd_iniciar_MouseEnter(object sender, EventArgs e)
        {
            cmd_iniciar.BackgroundImage = Image.FromFile(path + "cmd_inicio_high.jpg");
        }

        //===============================================================
        private void cmd_iniciar_MouseLeave(object sender, EventArgs e)
        {
            cmd_iniciar.BackgroundImage = Image.FromFile(path + "cmd_inicio_normal.jpg");
        }

        //===============================================================
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //===============================================================
        private void cmd_iniciar_Click(object sender, EventArgs e)
        {
            //chamar o início do jogo
            this.Hide();
            frmMain f = new frmMain(imagens[index]);
            f.ShowDialog();
            this.Show();
        }



    }
}
