using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Stiintific : Operatii
    {
        public double Factorial(double Val)
        {
            int x = 1;
            double Rez = 1;
            for (int i = 1; i <= Val; i++)
                Rez = Rez * Inmultire(x, i);
            return Rez;
        }
        public double Patrat(double Val)
        {
            double Rez = Inmultire(Val, Val);
            return Rez;
        }
        public double Cub(double Val)
        {
            double Rez = Inmultire(Inmultire(Val, Val), Val);
            return Rez;
        }
        public double Inverse(double Val)
        {
            double Rez = Impartire(1, Val);
            return Rez;
        }
        public double PowerOf10(double Val)
        {
            double Rez = 1;
            for (int i = 1; i <= Val; i++)
                Rez = Inmultire(Rez, 10);
            return Rez;
        }
        public double Radical(double Val)
        {
            double Rez = Val / 2;
            double aux = 0;
            while(Rez != aux)
            {
                aux = Rez;
                Rez = Impartire(Adunare(Impartire(Val, aux), aux), 2);
            }
            return Rez;
        }
        public double RadicalOrdin3(double Val)
        {
            double Rez = Math.Pow(Val, Impartire(1, 3));
            return Rez;
        }
        public double Sinus(double Val)
        {
            double radiani = Impartire(Inmultire(Math.PI, Val), 180);
            double grade = Math.Sin(radiani);
            return grade;
        }
        public double Cosinus(double Val)
        {
            double radiani = Impartire(Inmultire(Math.PI, Val), 180);
            double grade = Math.Cos(radiani);
            return grade;
        }
        public double Tangenta(double Val)
        {
            double radiani = Impartire(Inmultire(Math.PI, Val), 180);
            double grade = Math.Tan(radiani);
            return grade;
        }
        public double Log10(double Val)
        {
            double Rez = Math.Log10(Val);
            return Rez;
        }
        public double LogNat(double Val)
        {
            double Rez = Math.Log(Val);
            return Rez;
        }
    }
}
