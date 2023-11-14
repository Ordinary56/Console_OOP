using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_OOP
{
    public class TomorHenger : Henger
    {
        double fajsuly;
        public double GetFajSuly { get => fajsuly; }
        public double Suly { get => default; }

        public TomorHenger(double radius, int height) : base(radius, height)
        {
            fajsuly = 7.87;
        }
        public TomorHenger(double radius, int height, double weight) : base(radius, height)
        {
            fajsuly = weight;
        }
        public override double Terfogat()
        {
            return base.Terfogat();
        }
        public override string ToString()
        {
            return base.ToString() + $"fajsúly: {fajsuly}";
        }
    }
}