using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_3
{
    class Figure_work
    {
        private List<shape> figure;
        private void Show_all_figure() {
            foreach (shape sha in this.figure) {
                sha.Drow();
            }
        }
           private void Insert_figure() {
            int choose;
            char symb;
            int lenh, wid;
            Console.WriteLine("Pick the figure to insertation\n");
            Console.WriteLine("press 1 to choose rectengol");
            Console.WriteLine("press 2 to choose rhomb");
            Console.WriteLine("press 3 to choose trapeze");
            Console.WriteLine("press 4 to choose triangol");
            Console.WriteLine("press 5 to choose polygon\n");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose) {
                case 1:
                    rectengol temp_rect;
                    Console.WriteLine("Enter length of rectangle");
                    lenh = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter width of rectangle");
                    wid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter symbol for building rectangle");
                    symb = Console.ReadKey().KeyChar;
                    temp_rect = new rectengol(lenh, wid, symb);
                    this.figure.Add(temp_rect);
                    break;
                case 2:
                    rhomb rhomb_temp;
                    Console.WriteLine("Enter length of side rhomb");
                    lenh = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter symbol for building rhomb");
                    symb = Console.ReadKey().KeyChar;
                    rhomb_temp = new rhomb (lenh, symb);
                    this.figure.Add(rhomb_temp);
                    break;
                case 3:
                    trapeze temp_trap;
                    Console.WriteLine("Enter upper place of trapeze");
                    lenh = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter side part of trapeze");
                    wid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter symbol for building trapeze");
                    symb = Console.ReadKey().KeyChar;
                    temp_trap = new trapeze(lenh, wid, symb);
                    this.figure.Add(temp_trap);
                    break;
                case 4:
                    triangol trio;
                    Console.WriteLine("Enter length of side triangol");
                    lenh = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter symbol for building triangol");
                    symb = Console.ReadKey().KeyChar;
                    trio = new triangol(lenh, symb);
                    this.figure.Add(trio);
                    break;
                case 5:
                    polygon temp_pol;
                    Console.WriteLine("Enter length  of polygon without sharp corner");
                    lenh = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter width  of polygon");
                    wid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter symbol for building polygon");
                    symb = Console.ReadKey().KeyChar;
                    temp_pol = new polygon(wid,lenh,symb);
                    this.figure.Add(temp_pol);
                    break;
                default:
                    Console.Clear();
                    this.Menu();
                    break;
            }
        }
        public void Menu()
        {
            Console.WriteLine("Press 1 to create figure");
            Console.WriteLine("Press 2 to show  all figures");
            try
            {
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        this.Insert_figure();
                        this.Menu();
                        break;
                    case 2:
                        this.Show_all_figure();
                        this.Menu();
                        break;
                    default:
                        Console.WriteLine("Bey");
                        Environment.Exit(0);
                        break;



                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public Figure_work() {
            this.figure = new List<shape>();
        }
    }
}
