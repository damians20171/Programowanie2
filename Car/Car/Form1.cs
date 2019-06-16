using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Car_Racing : Form
    {
        public Car_Racing()
        {
            InitializeComponent();
            gameover.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gamespeed);
            enemy(gamespeed);
            gameOver();
            coins(gamespeed);
            coinscollection();
        }

        int collectedcoins = 0;
        Random r = new Random();
        int x, y;

        void enemy(int speed)
        {
            if (enemy1.Top >= 300)
            { x = r.Next(0, 75);
                y = r.Next(0, 10);
                enemy1.Location = new Point(x, y);
            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 300)
            {
                x = r.Next(80, 160);
                y = r.Next(0, 10);
                enemy2.Location = new Point(x, y);
            }
            else { enemy2.Top += speed; }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 300)
            {
                x = r.Next(0, 40);
                y = r.Next(0, 10);
                coin1.Location = new Point(x, y);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 300)
            {
                x = r.Next(40, 80);
                y = r.Next(0, 10);
                coin2.Location = new Point(x, y);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 300)
            {
                x = r.Next(80, 120);
                y = r.Next(0, 10);
                coin3.Location = new Point(x, y);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 300)
            {
                x = r.Next(120, 160);
                y = r.Next(0, 10);
                coin4.Location = new Point(x, y);
            }
            else { coin4.Top += speed; }
        }

        void gameOver()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;

            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;

            }

        }
        void moveLine(int speed)
        {
            if (pictureBox1.Top>= 300)
                { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 300)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 300)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 300)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= 300)
            { pictureBox5.Top = 0; }
            else { pictureBox5.Top += speed; }




        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(80, 160);
                coin1.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(80, 160);
                coin2.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(80, 160);
                coin3.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(80, 160);
                coin4.Location = new Point(x, 0);

            }

        }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                {
                    if(car.Left >2)
                    car.Left += -8;
                }
            if (e.KeyCode == Keys.Right)
                {
                    if (car.Right< 180)
                    car.Left += 8;  
                }
            if(e.KeyCode == Keys.Up)
                if(gamespeed < 21)
                { gamespeed++; }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed >0)
                { gamespeed--; }
            }
        }
    }
}
