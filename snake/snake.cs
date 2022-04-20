using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class snake
    {
        public List<Panel> snakeBody = new List<Panel>();
        public string smer;
        public int rychlost;
        public Color color;
        private int grid = 20;

        public snake(string smer, int rychlost, Color color)
        {
            this.smer = smer;
            this.rychlost = rychlost;
            this.color = color;
        }


        public Panel hlava(int x, int y)
        {
            Panel hrac = new Panel();
            hrac.BackColor = color;
            hrac.Location = new Point(x, y);
            hrac.Size = new Size(grid, grid);
            snakeBody.Add(hrac);
            return hrac;
        }
        public void move()
        {
            if (smer == "up")
            {
                snakeBody[0].Top -= grid;
            }
            else if (smer == "down")
            {
                snakeBody[0].Top += grid;
            }
            else if (smer == "right")
            {
                snakeBody[0].Left += grid;
            }
            else if (smer == "left")
            {
                snakeBody[0].Left -= grid;
            }
        }
        public void papani(List<PictureBox> jidlo, Form form)
        {

            for (int i = 0; i < jidlo.Count; i++)
            {
                if (jidlo.Count >= 1)
                {
                    if (snakeBody[0].Top == jidlo[i].Top && snakeBody[0].Left == jidlo[i].Left)
                    {
                        pridaniTela(jidlo[i].Left, jidlo[i].Top, form);
                        jidlo[i].Dispose();
                        jidlo.RemoveAt(i);
                        rychlost -= rychlost / 100;
                    }
                }
            }
        }
        public void pridaniTela(int x, int y, Form form)
        {
            Panel telo = new Panel();
            telo.Left = x;
            telo.Top = y;
            telo.Width = 20;
            telo.Height = 20;
            telo.BackColor = color;
            snakeBody.Add(telo);
            form.Controls.Add(telo);
        }
        public void moveSnake(Form form)
        {
            int x = snakeBody[0].Left;
            int y = snakeBody[0].Top;
            move();
            for (int i = 1; i < snakeBody.Count; i++)
            {
                int z = snakeBody[i].Left;
                int l = snakeBody[i].Top;
                snakeBody[i].Left = x;
                snakeBody[i].Top = y;
                x = z;
                y = l;
            }
            lose(form);
        }
        public void lose(Form form)
        {
            if (snakeBody[0].Left >= form.Width || snakeBody[0].Left < 0 || snakeBody[0].Top >= form.Height || snakeBody[0].Top < 0) form.Close();
            if(snakeBody.Count > 1)
            {
                for (int i = 1; i < snakeBody.Count; i++)
                {
                    if (snakeBody[0].Left == snakeBody[i].Left && snakeBody[0].Top == snakeBody[i].Top) form.Close();
                }
            }
        }
    }
}
