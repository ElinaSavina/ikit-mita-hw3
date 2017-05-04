using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public event EventHandler<int> NewNumber;
        Random ran = new Random();

        public void Generate()
        {
            int d = ran.Next(100);
            NewNumber?.Invoke(this, d);
        }
    }
}
