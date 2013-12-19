using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int a=1,moved,b,score,speed;
        Boolean mlcar, mmcar, mrcar;
        Random chance = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score = 0;
            carl.Location = new Point(-3, -175);
            carm.Location = new Point(152, -175);
            carr.Location = new Point(307, -175);
            speed = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score++;
            label1.Text = score.ToString();
            if (score % 40 == 0)
                timer1.Interval = timer1.Interval - 5;
         
            moved++;
           

                if (moved > 18)
                {
                    do{
                    a = chance.Next(1, 4);
                    }
                    while (b == a);
                    moved = 0;
                }
            b = a;

            if (a == 1)
                mlcar = true;
            if (a == 2)
                    mmcar = true;
            if (a==3)
                    mrcar = true;

            if (mlcar == true)
            {
                carl.Location = new Point(carl.Location.X, carl.Location.Y + + 20);
                if (carl.Location.Y > 490)
                {
                    mlcar = false;
                    carl.Location = new Point(carl.Location.X, -175);
                }

            }
            if (mmcar == true)
            {
                carm.Location = new Point(carm.Location.X, carm.Location.Y + + 20);
                if (carm.Location.Y > 490)
                {
                    mmcar = false;
                    carm.Location = new Point(carm.Location.X, -175);
                }

            }

            if (mrcar == true)
            {
                carr.Location = new Point(carr.Location.X, carr.Location.Y + + 20);
                if (carr.Location.Y > 490)
                {
                    mrcar = false;
                    carr.Location = new Point(carr.Location.X, -175);
                }

            }
            
            crash();
            
        }
        private void move_left()
        {
            player.Location = new Point(player.Location.X - 158, player.Location.Y);
      
        }
        private void move_right()
        {
            player.Location = new Point(player.Location.X + 158, player.Location.Y);
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            if (player.Location .X <300)
            move_right();
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            if (player.Location.X >0)
            move_left();
        }

        private void crash()
        {
            if (player.Location.X == -6 && carl.Location.Y > 163
                || player.Location.X == 152 && carm.Location.Y > 163
                || player.Location.X == 310 && carr.Location.Y > 163)
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER");
            }
            

        }



    }
}
