using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SilentBob : Gambler
    {
        public SilentBob() : base("Silent Bob")
        {
            
        }

        public override void FetchNewNumber(object sender, int digital)
        {
            if (!digital.IsEven()) Score++;
        }
    }
}
