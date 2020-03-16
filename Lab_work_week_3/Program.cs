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
            int res = 0;
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
            int[] mem = new int[725];
            for (int i = 0; i < mem.Length; i++) {
                if (i == 724)
                {
                    mem[i] = 280;
                }
                else
                {
                    mem[i] = 780;
                }
            }
            for (int i = 0; i < mem.Length; i++)
            {

                res += mem[i];
            }
            Console.WriteLine("Total memory for coppyng :{0}", res);
            Flash flash = new Flash("King", "RED", 256000, 60);
            Console.WriteLine(flash.All_info());
            for (int i = 0; i < mem.Length; i++)
            {
                flash.Copy_data_from(ref mem[i]);
                if (mem[i] > 0)
                {
                    break;
                }
            }
            Console.WriteLine(flash.All_info());
            DVD dVD = new DVD("sams", "X12", 20, "oneside");
            DVD dVd = new DVD("kingston", "ml", 20, "twoside");
            Console.WriteLine(dVD.All_info());
            for (int i = 0; i < mem.Length; i++)
            {
                dVD.Copy_data_from(ref mem[i]);
                if (mem[i] > 0) {
                    break;
                }
            }
            Console.WriteLine(dVD.All_info());
            Console.WriteLine(dVd.All_info());
            for (int i = 0; i < mem.Length; i++)
            {
                dVd.Copy_data_from(ref mem[i]);
                if (mem[i] > 0)
                {
                    break;
                }
            }
            HDD hDD = new HDD("WD", "Blue", 40, 3);
            Console.WriteLine(hDD.All_info());
            for (int i = 0; i < mem.Length; i++)
            {
                hDD.Copy_data_from(ref mem[i]);
                if (mem[i] > 0)
                {
                    break;
                }
            }
            Console.WriteLine(hDD.All_info());
           // Console.WriteLine(dVd.All_info());
            res = 0;
            for (int i = 0; i < mem.Length; i++) {

                res += mem[i];
            }
            Console.WriteLine("Memory left for copying :{0}",res);
        }
    }
}
