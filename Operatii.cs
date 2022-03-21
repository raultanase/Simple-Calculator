using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operatii
    {
        public double Val { get; set; }
        //private double Val2 { get; set; }
        public string Semn { get; set; }
        public bool ok { get; set; }

        public double Adunare(double Val, double Val2)
        {
            return Val + Val2;
        }

        public double Scadere(double Val, double Val2)
        {
            return Val - Val2;
        }

        public double Inmultire(double Val, double Val2)
        {
            return Val * Val2;
        }

        public double Impartire(double Val, double Val2)
        {
            return Val / Val2;
        }
    }
}
