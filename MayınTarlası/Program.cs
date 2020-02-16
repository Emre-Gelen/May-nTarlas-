using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayınTarlası
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Mayın mayın = new Mayın();
            Yokedici ykd = new Yokedici();
             mayın.mayınolustur();
            ConsoleKeyInfo basılantus;
            do
            {
                basılantus = Console.ReadKey();
                ykd.hareketet(basılantus);
                ykd.olustur();
                mayın.mayınciz();
                if (basılantus.Key == ConsoleKey.B)
                {
                    if (ykd.imha(mayın) == true)
                    {
                        Console.Beep();
                    }
                    else if (ykd.imha(mayın) == false)
                    {
                        Yokedici.hak--;
                    }
                }
                ykd.skorgoster();
            } while (basılantus.Key != ConsoleKey.Spacebar);
        }
    }
}
