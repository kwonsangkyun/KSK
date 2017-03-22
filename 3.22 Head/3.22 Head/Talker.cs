using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3._22_Head
{
    class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
        {
            string finalstring = "";
            for (int count = 0; count < numberOfTimes; count++)
                finalstring += thingToSay + "\n";

            MessageBox.Show(finalstring);

            return finalstring.Length;
            
        }
        

    }
}
