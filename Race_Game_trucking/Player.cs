using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Game_trucking
{
   public class Player
    {

        public int budget(String record, int winner, int budget) {
            String[] data = record.Split('-');
            if (Convert.ToInt32(data[2]) == winner)
            {
                return Convert.ToInt32(data[1]) + budget;
            }
            else {
                return budget-Convert.ToInt32(data[1]);
            }
        }
    }
}
