using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {        

        static void Main(string[] args)
        {
            Numbertron num = new Numbertron();
            int n = 0;
            Console.Write("Введите целое число больше 0: ");
            string s = Console.ReadLine();
            while (!int.TryParse(s, out n) || n == 0)
            {
                Console.WriteLine("Число должно быть целым и больше 0. Проверьте введенные данные и попробуйте снова.");
                Console.Write("Введите целое число больше 0: ");
                s = Console.ReadLine();
            }

            var jay = new Jay();
            var bob = new SilentBob();

            num.NewNumber += jay.FetchNewNumber;
            num.NewNumber += bob.FetchNewNumber;

            for (int i = 0; i < n; i++)
            {
                num.Generate();                
            }
            
            if (jay.Score > bob.Score) Console.WriteLine(jay.Name);
            else if (jay.Score < bob.Score) Console.WriteLine(bob.Name);
            else Console.WriteLine("DRAW");

            Console.ReadKey();
        }

       
    }
}
