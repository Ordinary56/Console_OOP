using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Console_OOP
{
    public class Cso : Henger
    {
         double falVastagsag;

        public Cso(double radius, int height) : base(radius, height)
        {
            falVastagsag = 1;
        }
        public Cso(double radius, int height, double wallthickness) : base(radius,height)
        {
            falVastagsag = wallthickness;
        }

        public override double Terfogat()
        {
            return base.Terfogat() - Math.Pow(sugar-falVastagsag, 2) * Math.PI * magassag;
        }

        public double FalVastagsag
        {
            get => falVastagsag;
        }

       
        public override string ToString()
        {
            return base.ToString() + $"falvastagsága: {FalVastagsag}";
        }
    }
}