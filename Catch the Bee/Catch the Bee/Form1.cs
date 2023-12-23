using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_the_Bee
{
    public partial class Form1 : Form
    {
        int time = 30;
        int x;
        int y;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moveTheBee(int x, int y)
        {

            button1.Location = new Point(x, y);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(x, y);
            timer1.Stop();

            MessageBox.Show("You Won");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = random.Next(1, 1123);
            y = random.Next(1, 622);


            moveTheBee(x, y);
            time--;
            label1.Text = time.ToString();

            if (time == 20)
            {
                timer1.Interval = 500;
            }
            else if (time == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time finished");
            }
        }
    }
}
