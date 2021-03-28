using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Game_trucking
{
   public class Runner
    {
        public int getNo() {
            Random rd = new Random();
            return rd.Next(1, 60);
        }
        public int move(PictureBox pb) {
            if (pb.Left <= 750)
            {
                pb.Left += getNo();
                return 0;
            }
            else {
                return 1;
            }
            
            
        }
    }
}
