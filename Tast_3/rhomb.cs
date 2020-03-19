using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_3
{
    class rhomb:shape
    {
        private int lenght;
        public override void Drow()
        {
            Console.WriteLine("\tRHOMB");
            Console.WriteLine();
            for (int i=0;i<this.lenght;i++)
            {
                for ( int j=0;j<(this.lenght+this.lenght);j++)
                {
                    if (((i != this.lenght - 1) && (j == this.lenght - i)) || ((i != this.lenght - 1)&&j == (this.lenght + this.lenght - 1) - i))
                    {
                        Console.Write(this.symb);

                    } else if ((i==0&&j>this.lenght)|| (i == this.lenght-1 && j <= this.lenght&&j>0))
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
        public rhomb(int len, char b) {
            this.lenght = len;
            this.symb = b;
        }
    }
}
