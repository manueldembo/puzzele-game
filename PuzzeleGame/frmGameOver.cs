using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuzzeleGame
{
    //====================================================================
    //quadro do fim de jogo
    //====================================================================
    public partial class frmGameOver : Form
    {
        //====================================================================
        public frmGameOver()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            //carrega um fundo do formulário
            this.BackgroundImageLayout = ImageLayout.None;
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img_game_over.jpg");

            cmd_menu_inicial.BackgroundImage = Image.FromFile(Application.StartupPath + @"\cmd_menu_normal.jpg");
        }

        //====================================================================
        private void frmGameOver_Load(object sender, EventArgs e)
        {

        }

        //==========================================================================
        private void cmd_menu_inicial_MouseEnter(object sender, EventArgs e)
        {
            cmd_menu_inicial.BackgroundImage = Image.FromFile(Application.StartupPath + @"\cmd_menu_high.jpg");
        }

        //==========================================================================
        private void cmd_menu_inicial_MouseLeave(object sender, EventArgs e)
        {
            cmd_menu_inicial.BackgroundImage = Image.FromFile(Application.StartupPath + @"\cmd_menu_normal.jpg");
        }

        //==========================================================================
        private void cmd_menu_inicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
