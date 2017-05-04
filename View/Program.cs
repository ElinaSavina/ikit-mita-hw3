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
        private static Jay _jay = new Jay();
        private static SilentBob _bob = new SilentBob();

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

            num.NewNumber += OnNewNumber;

            for (int i = 0; i < n; i++)
            {
                num.Generate();
            }
            
            if (_jay.Score > _bob.Score) Console.WriteLine(_jay.Name);
            else if (_jay.Score < _bob.Score) Console.WriteLine(_bob.Name);
            else Console.WriteLine("DRAW");

            Console.ReadKey();
        }

        public static void OnNewNumber(object sender, int d)
        {
            _jay.FetchNewNumber(d);
            _bob.FetchNewNumber(d);
        }
    }
}
