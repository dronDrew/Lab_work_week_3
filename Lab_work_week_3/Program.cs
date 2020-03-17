using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_week_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Range_array<string> A= new Range_array<string>();
            Range_array<string> B= new Range_array<string>(-9,6);
            Range_array<string> C = new Range_array<string>(1, 10,"Freank");
            C[2] = "John";
            C[9] = "alphread";
            B[-5] = "Greag";
            B[5] = "olaf";
            Console.WriteLine(C[1]);
            Console.WriteLine(C.Lenght());
            Console.WriteLine(B.Lenght());
            A.SetSize(10, 20);
            Console.WriteLine(A.Lenght());
            Console.WriteLine(A.GetLowerBound());
            Console.WriteLine(A.GetUpperBound());
            Pr2 prog = new Pr2();
            prog.Menu();
        }
    }
}
