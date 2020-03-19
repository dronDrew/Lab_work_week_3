using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_3
{
    class trapeze :shape
    {
        private int upperside;
        private int lowwerside;
        private int sidelen;
        public override void Drow()
        {
            Console.WriteLine("\tTrapeze");
            Console.WriteLine();
            for (int i=0;i<this.sidelen;i++) {

                for (int j = 0; j < this.lowwerside; j++) {
                    if (i == this.sidelen - 1) {
                        Console.Write(this.symb);
                    }
                    else if (j >= this.sidelen-1 && j <= (this.upperside-1) + (this.sidelen-1)&&i==0)
                    {
                        Console.Write(this.symb);
                    }
                    else if (j == (this.sidelen-1) - i || j == (this.upperside-1) + (this.sidelen-1) + i)
                    {
                        Console.Write(this.symb);
                    }
                    else {
                        Console.Write(" ");
                    }
                
                }
                Console.WriteLine();
            }
            
        }
        public trapeze(int upp, int side, char b) {
            this.upperside = upp;
            this.lowwerside = (upp+side+side/2)+1;
            this.sidelen = side;
            this.symb = b;
        }

    }
}
