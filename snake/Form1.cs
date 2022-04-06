using System;
using System.Collections;
namespace snake
{
    public partial class Form1 : Form
    {
        public List<PictureBox> jidloAR = new List<PictureBox>();
        public List<Panel> snake = new List<Panel>();
        private Random rd = new Random();
        private string smer = "right";
        private int pocet = 20;
        private int pocetJidla = 0;
        public Form1()
        {
            InitializeComponent();
            snake.Add(hlava);
        }
        public void create()
        {
            if (pocetJidla < 3)
            {
                PictureBox jidlo = new PictureBox();
                jidlo.Size = new Size(20, 20);
                jidlo.Location = new Point(randomPozice(this.Width), randomPozice(this.Height));
                jidlo.BackColor = Color.Black;
                jidlo.BackgroundImage = Properties.Resources.apple1;
                jidlo.BackgroundImageLayout = ImageLayout.Stretch;
                jidloAR.Add(jidlo);
                this.Controls.Add(jidlo);
                pocetJidla++;
            }
        }
        public int randomPozice(int velikost)
        {
            int pozice = (velikost / pocet) - 1;
            return rd.Next(1, pozice + 1) * pocet;

        }
        public void move()
        {
            if (smer == "up")
            {
                hlava.Top -= pocet;
            }
            else if (smer == "down")
            {
                hlava.Top += pocet;
            }
            else if (smer == "right")
            {
                hlava.Left += pocet;
            }
            else if (smer == "left")
            {
                hlava.Left -= pocet;
            }
        }

        public bool prohra()
        {
            if (hlava.Left >= this.Width || hlava.Left < 0 || hlava.Top >= this.Height || hlava.Top < 0)
            {
                return true;
            }
            return false;
        }
        private void papani()
        {
            for (int i = 0; i < jidloAR.Count; i++)
            {
                if (hlava.Top == jidloAR[i].Top && hlava.Left == jidloAR[i].Left)
                {
                    jidloAR[i].Dispose();
                    pridat(jidloAR[i].Left, jidloAR[i].Top);
                    jidloAR.RemoveAt(i);
                    pocetJidla--;
                }
            }
        }
        private void pridat(int x, int y)
        {
            Panel panel = new Panel();
            panel.Left = x;
            panel.Top = y;
            panel.Width = 20;
            panel.Height = 20;
            panel.BackColor = Color.FromArgb(rd.Next(0, 256), rd.Next(0, 256), 0);
            snake.Add(panel);
            this.Controls.Add(panel);
        }
        private void moveSnake()
        {
            int x = snake[0].Left;
            int y = snake[0].Top;
            move();
            for (int i = 1; i < snake.Count; i++)
            {
                int z = snake[i].Left;
                int l = snake[i].Top;
                snake[i].Left = x;
                snake[i].Top = y;
                x = z;
                y = l;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prohra())
            {
                this.Close();
            }
            else
            {
                moveSnake();
                create();
                papani();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && smer != "down")
            {
                smer = "up";
            }
            else if (e.KeyCode == Keys.Down && smer != "up")
            {
                smer = "down";
            }
            else if (e.KeyCode == Keys.Right && smer != "left")
            {
                smer = "right";
            }
            else if (e.KeyCode == Keys.Left && smer != "right")
            {
                smer = "left";
            }
        }
    }
}