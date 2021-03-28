using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Game_trucking
{
    public partial class Form1 : Form
    {
        int x = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x < 100)
            {
                x = x + 10;
                progressBar1.Value = x;
            }
            if(x==100){
                timer1.Stop();
                MainArea obj = new MainArea();
                obj.Show();
            }

        }
    }
}
