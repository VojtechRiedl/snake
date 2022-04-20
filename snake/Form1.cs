using System;
using System.Collections;
namespace snake
{
    public partial class Form1 : Form
    {
        public snake hrac1;
        public snake hrac2;
        public List<PictureBox> jidloAR = new List<PictureBox>();
        private Random rd = new Random();
        private int grid = 20;
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;

        }
        public void create()
        {
            if (jidloAR.Count <= 5)
            {
                PictureBox jidlo = new PictureBox();
                jidlo.Size = new Size(grid, grid);
                jidlo.Location = new Point(randomPozice(this.Width - 20), randomPozice(this.Height - 20)); 
                jidlo.BackColor = Color.Black;
                jidlo.BackgroundImage = Properties.Resources.apple1;
                jidlo.BackgroundImageLayout = ImageLayout.Stretch;
                jidloAR.Add(jidlo);
                this.Controls.Add(jidlo);
            }
        }
        public int randomPozice(int velikost)
        {
            int pozice = (velikost / grid);
            return rd.Next(1, pozice) * grid;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(hrac2 != null)
            {
                if (e.KeyCode == Keys.Up && hrac2.smer != "down")
                {
                    hrac2.smer = "up";
                }
                else if (e.KeyCode == Keys.Down && hrac2.smer != "up")
                {
                    hrac2.smer = "down";
                }
                else if (e.KeyCode == Keys.Right && hrac2.smer != "left")
                {
                    hrac2.smer = "right";
                }
                else if (e.KeyCode == Keys.Left && hrac2.smer != "right")
                {
                    hrac2.smer = "left";
                }
            }

            if (e.KeyCode == Keys.W && hrac1.smer != "down")
            {
                hrac1.smer = "up";
            }
            else if (e.KeyCode == Keys.S && hrac1.smer != "up")
            {
                hrac1.smer = "down";
            }
            else if (e.KeyCode == Keys.D && hrac1.smer != "left")
            {
                hrac1.smer = "right";
            }
            else if (e.KeyCode == Keys.A && hrac1.smer != "right")
            {
                hrac1.smer = "left";
            }
        }

        private void hrac2_timer_Tick(object sender, EventArgs e)
        {
            hrac2.moveSnake(this);
            hrac2.papani(jidloAR, this);
            if (hrac2.rychlost > 50) hrac2_timer.Interval = hrac2.rychlost;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            create();
            hrac1.moveSnake(this);
            hrac1.papani(jidloAR, this);

            if (hrac1.rychlost > 20) hrac1_timer.Interval = hrac1.rychlost;
        }

        private void GameName_Click(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hrac1 = new snake("right", 500, Color.Blue);
            this.Controls.Add(hrac1.hlava(randomPozice(this.Width - 20), randomPozice(this.Height - 20)));
            single.Enabled = true;
            hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hrac1 = new snake("right", 250, Color.Maroon);
            this.Controls.Add(hrac1.hlava(randomPozice(600), randomPozice(500)));
            hrac2 = new snake("left", 250, Color.Cyan);
            this.Controls.Add(hrac2.hlava(randomPozice(600), randomPozice(500)));
            hrac1_timer.Enabled = true;
            hrac2_timer.Enabled = true;
            hra.Enabled = true;

            hide();
            
        }
        private void hide()
        {
            this.Controls.Remove(GameName);
            this.Controls.Remove(button1);
            this.Controls.Remove(button2);
        }
        private void vyhra()
        {
            for (int i = 0; i < hrac1.snakeBody.Count; i++)
            {
                if(hrac2.snakeBody[0].Left == hrac1.snakeBody[i].Left && hrac2.snakeBody[0].Top == hrac1.snakeBody[i].Top)
                {
                    if (i == 0)
                    {
                        text();
                    }
                    else
                    {
                        label1.Text = "Hr·Ë 1 vyhr·l";
                        hrac1_timer.Stop();
                        hrac2_timer.Stop();
                        hra.Stop();
                    }
                }
            }
            for (int i = 0; i < hrac2.snakeBody.Count; i++)
            {
                if (hrac1.snakeBody[0].Left == hrac2.snakeBody[i].Left && hrac1.snakeBody[0].Top == hrac2.snakeBody[i].Top)
                {
                    if (i == 0)
                    {
                        text();
                    }
                    else
                    {
                        label1.Text = "Hr·Ë 2 vyhr·l";
                        hrac1_timer.Stop();
                        hrac2_timer.Stop();
                        hra.Stop();


                    }
                }
            }
        }

        private void single_Tick(object sender, EventArgs e)
        {
            create();

            hrac1.moveSnake(this);
            hrac1.papani(jidloAR, this);

            if (hrac1.rychlost > 20) hrac1_timer.Interval = hrac1.rychlost;
        }

        private void hra_Tick(object sender, EventArgs e)
        {
            create();
            vyhra();
        }
        private void text()
        {
            if (rd.Next(1, 2) == 1)
            {
                label1.Text = "Hr·Ë 1 vyhr·l";
                hrac1_timer.Stop();
                hrac2_timer.Stop();
                hra.Stop();
            }
            else
            {
                label1.Text = "Hr·Ë 2 vyhr·l";
                hrac1_timer.Stop();
                hrac2_timer.Stop();
                hra.Stop();
            }
        }
    }
}