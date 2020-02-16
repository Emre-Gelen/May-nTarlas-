using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayınTarlası
{
    class Yokedici
    {
        public int X = 1;public int Y = 1;
        public int skor = 0;
        public static int hak = 10;
         
        public void olustur ()
        {
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            Console.Write("Y");
        }
        public void hareketet(ConsoleKeyInfo basılantus )
        {
            if (basılantus.Key == ConsoleKey.UpArrow)
                Y--;
            else if (basılantus.Key == ConsoleKey.DownArrow)
                Y++;
            else if (basılantus.Key == ConsoleKey.RightArrow)
                X++;
            else if (basılantus.Key == ConsoleKey.LeftArrow)
             X--; 
            if (X == 11)
                X = 1;
            if (X == 0)
                X = 10;
            if (Y == 11)
                Y = 1;
            if (Y == 0)
                Y = 10;
        }
        public bool imha(Mayın mayınlar)
        {
            int i = 0;
            bool sonuc = false;
            for ( i = 0; i < 5; i++)
            {
                if (X == mayınlar.mayınyerX[i] && Y == mayınlar.mayınyerY[i] && mayınlar.mayıns[i] != "O")
                {
                    sonuc = true;
                    skor++;
                    mayınlar.mayıns[i] = "O";
                }
             }
            
            
            if (hak == 0)
            {
                Console.Clear();
                Console.WriteLine("Hakkınız Kalmadı!!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (skor == 5)
            {
                Console.Clear();
                Console.WriteLine("Tebrikler tüm mayınları temizlediniz!!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return sonuc;
        }
       
        public void skorgoster()
        {
            Console.SetCursorPosition(10, 25);
            Console.WriteLine("Skor:"+skor);
            Console.SetCursorPosition(10, 27);
            Console.WriteLine("Hak:"+hak);
        }
    }
}
