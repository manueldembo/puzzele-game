using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuzzeleGame
{
    //===============================================================
    public partial class frmMain : Form
    {
        Image imagem_original;
        List<PictureBox> lista_pics;
        List<Rectangle> lista_rectangulos_finais;

        bool mover = false;
        int posX = 0;
        int posY = 0;

        int posXinicial = 0;
        int posYinicial = 0;

        int toleranciaX = 10;
        int toleranciaY = 10;

        string path;

        //imagem
        string ficheiro_imagem;

        //===============================================================
        public frmMain(string ficheiro_imagem)
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            this.ficheiro_imagem = ficheiro_imagem;

            path = Application.StartupPath + @"\";

            //carregar imagem de fundo do quadro
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img_main.png");

            //carregar a imagem
            imagem_original = Image.FromFile(ficheiro_imagem);

            Bitmap imgback = new Bitmap(pic_exemplo.Width, pic_exemplo.Height);
            Graphics grafico = Graphics.FromImage(imgback);
            grafico.DrawImage(imagem_original, 
                              new Rectangle(0, 0, pic_exemplo.Width, pic_exemplo.Height),
                              new Rectangle(0, 0, imagem_original.Width, imagem_original.Height),
                              GraphicsUnit.Pixel);

            pic_exemplo.BackgroundImage = imgback;

            //definir lista de pics
            lista_pics = new List<PictureBox>()
            {
                pic_01, pic_02, pic_03, pic_04, pic_05, pic_06, pic_07, pic_08, pic_09
            };

            int margem = 15;
            //definir rectanglus
            lista_rectangulos_finais = new List<Rectangle>()
            {
                new Rectangle(margem, margem, 100, 100),
                new Rectangle(margem + 100, margem, 100, 100),
                new Rectangle(margem + 200, margem, 100, 100),
                
                new Rectangle(margem, margem + 100, 100, 100),
                new Rectangle(margem + 100, margem + 100, 100, 100),
                new Rectangle(margem + 200, margem + 100, 100, 100),

                new Rectangle(margem, margem + 200, 100, 100),
                new Rectangle(margem + 100, margem + 200, 100, 100),
                new Rectangle(margem + 200, margem + 200, 100, 100),
            };

            //criar os eventos
            foreach (PictureBox pic in lista_pics)
            {
                pic.MouseDown += pic_MouseDown;
                pic.MouseUp += pic_MouseUp;
                pic.MouseMove += pic_MouseMove;
            }

            //carregar imagem do botão
            cmd_menu_inicial.BackgroundImage = Image.FromFile(path + "cmd_menu_normal.jpg");
        }

        //===============================================================
        void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mover) return;

            Point localizacao = new Point(0, 0);

            localizacao.X = (sender as PictureBox).Left + (e.X - posX);
            localizacao.Y = (sender as PictureBox).Top + (e.Y - posY);

            (sender as PictureBox).Location = localizacao;
        }

        //===============================================================
        void pic_MouseUp(object sender, MouseEventArgs e)
        {
            //para o movimento
            mover = false;

            //devolver a imagem na sua posição inicial
            Rectangle r1 = new Rectangle(pic_referencia.Left, pic_referencia.Top, 
                                         pic_referencia.Left +  pic_referencia.Width,
                                         pic_referencia.Top +  pic_referencia.Height);

            PictureBox pic = (sender as PictureBox);

            Point p1 = new Point(pic.Left, pic.Top);
            Point p2 = new Point(pic.Left + pic.Width, pic.Top);
            Point p3 = new Point(pic.Left, pic.Top + pic.Height);
            Point p4 = new Point(pic.Left + pic.Width, pic.Top + pic.Height);

            //sistema de deteção de posição
            int index = Convert.ToInt16(pic.Name.Substring(4)) -1;

            //verificar se a peça foi posta no local correcto
            Rectangle rfinal = new Rectangle(lista_rectangulos_finais[index].X - toleranciaX,
                                              lista_rectangulos_finais[index].Y - toleranciaY,
                                              toleranciaX * 2, toleranciaY * 2);

            if (rfinal.Contains(p1))
            {
                pic.Location = new Point(lista_rectangulos_finais[index].X,
                                         lista_rectangulos_finais[index].Y);

                //lógica do final do jogo
                //verificar se todas a imagens estão no loacl correcto

                bool jogo_terminado = true;

                for (int i = 0; i < lista_pics.Count; i++ )
                {
                    Point pt1 = new Point(lista_pics[i].Left, lista_pics[i].Top);
                    Point pt2 = new Point(lista_rectangulos_finais[i].X, lista_rectangulos_finais[i].Y);
                    if (pt1 != pt2)
                    {
                        jogo_terminado = false;
                    }
                }

                if (jogo_terminado)
                {
                    frmGameOver f = new frmGameOver();
                    f.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                if(r1.Contains(p1) || r1.Contains(p2) || r1.Contains(p3) || r1.Contains(p4))
                    pic.Location = new Point(posXinicial, posYinicial);
            }
        }

        //===============================================================
        void pic_MouseDown(object sender, MouseEventArgs e)
        {
            //quando mause é pressionado dentro da pic
            posX = e.X;
            posY = e.Y;

            //guardar posição inicial
            posXinicial = (sender as PictureBox).Left;
            posYinicial = (sender as PictureBox).Top;

            //trazer a imagem para a frente
            (sender as PictureBox).BringToFront();

            //iniciar o movimento
            mover = true;
        }

        //===============================================================
        private void frmMain_Load(object sender, EventArgs e)
        {
            DestribuirImagensPelasPics();
            MisturarImagens();
        }

        //===============================================================
        private void DestribuirImagensPelasPics()
        {
            Bitmap imgback;
            Graphics graficos;

            int x = 0;
            int y = 0;
            int index = 0;

            foreach(PictureBox pic in lista_pics)
            {
                imgback = new Bitmap(100, 100);
                graficos = Graphics.FromImage(imgback);

                graficos.DrawImage(imagem_original,
                                   new Rectangle(0,0,100,100),
                                   new Rectangle(x, y, 100, 100),
                                    GraphicsUnit.Pixel);

                lista_pics[index].BackgroundImage = imgback;

                //atualizar as variáveis
                x += 100;
                if (x == 300)
                {
                    y += 100;
                    x = 0;
                }

                index++;
            }
        }

        //===============================================================
        private void MisturarImagens()
        { 
            //Shuffle
            Random rnd = new Random(DateTime.Now.Millisecond);

            foreach (PictureBox pic in lista_pics)
            {
                Point localizacao = new Point(rnd.Next(320, 550), rnd.Next(10, 250));
                pic.Location = localizacao;
            }

            //suffle da zorder
            int index;
            for (int m = 0; m <= 19; m++)
            {
                index = rnd.Next(0, lista_pics.Count);
                lista_pics[index].BringToFront();
            }
        }

        //===============================================================
        private void cmd_menu_inicial_MouseEnter(object sender, EventArgs e)
        {
            cmd_menu_inicial.BackgroundImage = Image.FromFile(path + "cmd_menu_high.jpg");
        }

        //===============================================================
        private void cmd_menu_inicial_MouseLeave(object sender, EventArgs e)
        {
            cmd_menu_inicial.BackgroundImage = Image.FromFile(path + "cmd_menu_normal.jpg");
        }

        //===============================================================
        private void cmd_menu_inicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


//alguns código importantes


            //grafico.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;


//if(r1.Contains(p1) || r1.Contains(p2) || r1.Contains(p3) || r1.Contains(p4))
//    (sender as PictureBox).Location = new Point(posXinicial, posYinicial);