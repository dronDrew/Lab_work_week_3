using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_3
{
    class triangol :shape
    {
        private int sideLeng;
        
        public override void Drow()
        {
            Console.WriteLine("\tTriangol");
            Console.WriteLine();
            for (int i = 0; i < this.sideLeng; ++i)
            {
                for (int j = 0; j < this.sideLeng; ++j)
                {
                    if (i == 0 && j==0)
                    {
                        Console.Write(this.symb);
                    }
                    else if (j <=i) {
                        Console.Write(this.symb);
                    }

                }

                Console.WriteLine();
            }
            Console.WriteLine();

        }
        public triangol(int side_leng, char b) {
            this.sideLeng = side_leng;
            this.symb = b;

        }

    }
}
