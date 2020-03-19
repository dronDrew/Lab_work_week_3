using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_3
{
    class rectengol :shape
    {
        private int lenght;
        private int width;
        public override void Drow()
        {
   
            Console.WriteLine("RECTENGOL");
            Console.WriteLine();
            for (int i = 0; i < this.width; ++i) {
                for (int j = 0; j < this.lenght; ++j)
                {
                    
                    Console.Write(this.symb);
    
                }
                
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        

        public rectengol(int len, int wid, char symbol) {
            this.symb = symbol;
            this.lenght = len;
            this.width = wid;
        }
    }
}
