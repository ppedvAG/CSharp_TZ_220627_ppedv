using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal interface IArbeit
    {
        public int Gehalt { get; set; }
        public string Job { get; set; }
        public void Auszahlung();
    }
}
