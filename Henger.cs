using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_OOP
{
    public class Henger
    {
        protected int magassag;
        protected double sugar;
        protected static int szuletesSzamlalo;

        public Henger(double radius, int height)
        {
            sugar = radius;
            magassag = height;
            szuletesSzamlalo++;
        }
        public int GetMagassag
        {
            get => magassag;
        }

        public double GetSugar
        {
            get => sugar;
        }

        public static int SzuletesSzamlalo
        {
            get => szuletesSzamlalo;
        }


        public virtual double Terfogat()
        {
            return Math.Pow(sugar, 2) * Math.PI * magassag; 
        }
        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {Terfogat():F2}; sugár:{GetSugar}; magasság:{GetMagassag};";
        }
    }
}