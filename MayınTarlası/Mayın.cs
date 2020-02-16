using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayınTarlası
{
    class Mayın
    {
       int X, Y;
       public int[] mayınyerX = new int[5];
       public int[] mayınyerY = new int[5];
       public string[] mayıns = new string[] { "", "", "","","" };
        public  void mayınolustur()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                X = rnd.Next(1, 10);
                Y = rnd.Next(1, 10);
                mayınyerX[i] = X;
                mayınyerY[i] = Y;
            }
        }
        public void mayınciz()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(mayınyerX[i], mayınyerY[i]);
                Console.Write(mayıns[i]);
            }
        }
    }
}
