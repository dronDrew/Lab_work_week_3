using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_3
{
    class polygon:shape
    {
        private int angleside;
        private int primeside;
        public override void Drow()

        {
            Console.WriteLine("\tPolygon");
            for (int i = 0; i < this.angleside; i++) 
            {
                for (int j = 0; j < (this.angleside + this.primeside); j++) {
                    if (((i == 0) && (j < this.primeside)) || ((i == this.angleside - 1) && (j < this.primeside)))
                    {
                        Console.Write(this.symb);
                    } else if (i>0&&i<=this.angleside/2) {
                        if (j == 0 || j == this.primeside + i) {

                            Console.Write(this.symb);
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }
                 else if ( i > this.angleside / 2&&i< this.angleside-1)
                {
                    if (j == 0 || j == this.primeside+this.angleside - i)
                    {

                        Console.Write(this.symb);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }

                else {
                        Console.Write(" ");
                    }
                
                }
                Console.WriteLine();
            }

        }
        public polygon(int side, int pside, char sym) {
            this.angleside = side;
            this.primeside = pside;
            this.symb = sym;
        }
    }
}
