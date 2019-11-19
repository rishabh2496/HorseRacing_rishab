using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HorseRacing_Rishab
{
   public class ScoreBoard : validation
    {
        int Rishab = 100, Sohan = 190, Mohan = 210;
        //this method is used to display the score board of the game 
        public void display(ComboBox lb, String horse, int amount, int indx)
        {
            if (indx == 0 && amount<=Rishab)
            {
                lb.Items[indx] = "Rishab-" + horse + "-" + amount;
            }
            else if (indx == 1 && amount<=Sohan)
            {
                lb.Items[indx] = "Sohan-" + horse + "-" + amount;
            }
            else if (indx == 2 && amount<=Mohan)
            {
                lb.Items[indx] = "Mohan-" + horse + "-" + amount;
            }

        }


        //this code is used to recent the account of the Player
        public void resetAccount(ComboBox cb, int winer)
        {
            for (int y = 0; y < 3; y++)
            {
                if (cb.Items[y].ToString().Contains("-"))
                {

                    int Horse = Convert.ToInt32(cb.Items[y].ToString().Substring(cb.Items[y].ToString().IndexOf('-') + 1, 1));
                    if (cb.Items[y].ToString().Contains("Rishab"))
                    {
                        String[] payment = cb.Items[y].ToString().Split('-');
                        if (Horse == winer)
                        {
                            Rishab += Convert.ToInt32(payment[2]);
                        }
                        else
                        {
                            Rishab -= Convert.ToInt32(payment[2]);
                        }
                        cb.Items[y] = "Rishab Budget is " + Rishab;

                    }

                    if (cb.Items[y].ToString().Contains("Sohan"))
                    {
                        String[] payment = cb.Items[y].ToString().Split('-');
                        if (Horse == winer)
                        {
                            Sohan += Convert.ToInt32(payment[2]);
                        }
                        else
                        {
                            Sohan -= Convert.ToInt32(payment[2]);
                        }
                        cb.Items[y] = "Sohan Budget is " + Sohan;

                    }
                    if (cb.Items[y].ToString().Contains("Mohan"))
                    {
                        String[] payment = cb.Items[y].ToString().Split('-');
                        if (Horse == winer)
                        {
                            Mohan += Convert.ToInt32(payment[2]);
                        }
                        else
                        {
                            Mohan -= Convert.ToInt32(payment[2]);
                        }
                        cb.Items[y] = "Mohan Budget is " + Mohan;

                    }





                }
            }
        }

   }
}
