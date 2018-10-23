using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber cp = new ComplexNumber(2,3);

            Console.WriteLine("Number is: " + cp.ToString());
            cp.SetImmaginaryPart(-3);
            Console.WriteLine("Number is: " + cp.ToString());
            Console.Write("Magnitude is: ");
            Console.WriteLine(cp.GetMagnitude());


            ComplexNumber cp2 = new ComplexNumber(1, -1);
            cp.Add(cp2);
            Console.Write("After adding: ");
            Console.WriteLine(cp.ToString());


            Console.Read();
        }

    }
}
