﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06f_Fahrzeugpark
{
    //vgl. Schiff
    public class PKW : Fahrzeug
    {
        public int AnzahlTueren { get; set; }

        public PKW(string name, int maxG, double preis, int anzTueren) : base(name, maxG, preis)
        {
            this.AnzahlTueren = anzTueren;
        }

        public override string Info()
        {
            return $"Der PKW {this.Name} kostet {this.Preis}. Er hat {this.AnzahlTueren} Türen.";
        }
        public override void Hupen()
        {
            Console.WriteLine($"{this.Name}: 'Hup Hup'");
        }
    }
}
