using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing_Rishab
{
   public class wholeProcess :ScoreBoard
    {
        //object of the random class to generate the no 
        Random obj = new Random();
        int no=52;
        int Rishab = 100, Sohan = 190, Mohan = 210;
        // method to generate a no for the process to run the horse 
        public int rank() {
                no = obj.Next(30);
                return no;
        }

        }


    
}
