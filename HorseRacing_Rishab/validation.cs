using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing_Rishab
{
    public class validation
    {
        //validation class that is used to check all the important details of the game for starting the race 
        public int check(String Name,String horse, int amount) {
            if (Name.Equals("") && horse.Equals("") && amount == 0)
            {
                MessageBox.Show("fill all the details for bet setting ");
                return 1;
            }
            else {
                return 0;
            }
        }
    }
}
