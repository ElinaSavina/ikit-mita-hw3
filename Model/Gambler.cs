using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Gambler
    {
        public string Name { get; }
        public int Score { get; protected set; }

        public Gambler(string name)
        {
            Name = name;
        }

        public abstract void FetchNewNumber(object sender, int digital);
    }
}
