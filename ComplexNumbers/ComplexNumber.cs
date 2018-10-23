using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class ComplexNumber
    {
        protected double realPart;
        protected double immaginaryPart;


        public ComplexNumber(double rp, double ip)
        {
            realPart= rp;
            immaginaryPart = ip;
        }

        public double GetRealPart() { return realPart; }

        public void SetRealPart(double realP) { this.realPart = realP; }

        public double GetImmaginaryPart() { return immaginaryPart; }

        public void SetImmaginaryPart(double immP) { this.immaginaryPart = immP; }

      
        public new string  ToString()
        {

           return "("+ realPart + "," + immaginaryPart + ")";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt( (Math.Pow(realPart ,2)) + (Math.Pow (immaginaryPart,2)) );
        }

        public void Add(ComplexNumber c2)
        {
            realPart += c2.GetRealPart();
            immaginaryPart += c2.GetImmaginaryPart();

        }
    }
}
