using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_week_3
{
    class Pr2
    {
        private List<Storage> device ;
        private double Work_computer;
        private double[] info_for_copy;
        private void Create_device() {
            int choice;
            Console.WriteLine("Press 1 to insert info about DVD");
            Console.WriteLine("Press 2 to insert info about Flash");
            Console.WriteLine("Press 3 to insert info about HDD");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    DVD temp;
                    string name, model,type;
                    double speed_read_and_wright;
                    Console.WriteLine("Enter name of DVD Produser");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter model of DVD ");
                    model = Console.ReadLine();
                    Console.WriteLine("Enter type oneside or twoside");
                    type = Console.ReadLine();
                    Console.WriteLine("Enter speed of wright and read on MB(megabyte)");
                    speed_read_and_wright = Convert.ToDouble(Console.ReadLine());
                    temp = new DVD(name, model, speed_read_and_wright, type);
                    this.device.Add(temp);
                    break;
                case 2:
                    Flash tempflash;
                    string nameflash, model_flash;
                    double Memory_cop,speed_USB_3_0;
                    Console.WriteLine("Enter name of Flash Produser");
                    nameflash = Console.ReadLine();
                    Console.WriteLine("Enter model of Flash ");
                    model_flash = Console.ReadLine();
                    Console.WriteLine("Enter memory volume in MB");
                    Memory_cop = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter speed of wright and read on MB(megabyte)");
                    speed_USB_3_0 = Convert.ToDouble(Console.ReadLine());
                    tempflash = new Flash(nameflash, model_flash, Memory_cop, speed_USB_3_0);
                    this.device.Add(tempflash);
                    break;
                case 3:
                    HDD tempHDD;
                    string nameHDD, modelHDD;
                    int dir;
                    double speed_USB_2_0;
                    Console.WriteLine("Enter name of HDD Produser");
                    nameHDD = Console.ReadLine();
                    Console.WriteLine("Enter model of HDD ");
                    modelHDD = Console.ReadLine();
                    Console.WriteLine("Enter quont of directory");
                    dir = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter speed HDD usb 2.0 on MB(megabyte)");
                    speed_USB_2_0 = Convert.ToDouble(Console.ReadLine());
                    tempHDD = new HDD(nameHDD, modelHDD, speed_USB_2_0, dir);
                    this.device.Add(tempHDD);
                    break;
                default:
                    this.Create_device();
                    break;
            }
        }
        public void Menu() {
            int Choice;
            Console.WriteLine("Press 1 to insert info about device");
            Console.WriteLine("Press 2 to copy data");
            Console.WriteLine("Press 3 to time copy calculate get result");
            Console.WriteLine("Press 4 to calculate how many devices for copy will needed");
            Console.WriteLine("Press 5 to calculate total memory cop of all divices");
            Choice =Convert.ToInt32(Console.ReadLine());
            switch (Choice) {
                case 1:
                    this.Create_device();
                    this.Menu();
                    break;
                case 2:
                    Console.WriteLine("Copy start");
                    this.Start_copy();
                    Console.WriteLine("Copy end");
                    this.Menu();
                    break;
                case 3:
                    this.Time_copy_calculate();
                    this.Menu();
                    break;
                case 4:
                    this.Quont_dev_calculate();
                    this.Menu();
                    break;
                case 5:
                    double res = this.TotalMemoryOfdivece();
                    Console.WriteLine("All inserted by you devices have {0} total memory (MB)", res);
                    this.Menu();
                    break;
                default:
                    this.Menu();
                    break;
            
            }

        }
        private double TotalMemoryOfdivece() {
            double res = 0;
            foreach(var ob in this.device)
            {
                res += ob.Memory_capacity;
            }
            return res;
        }
        private void Start_copy() {
                foreach (var ob in this.device) {
                for (int i = 0; i < this.info_for_copy.Length; i++)
                {
                    ob.Copy_data_from(ref this.info_for_copy[i]);
                    if (this.info_for_copy[i] > 0) {
                        break;
                    }
                }
                
                }
        }
       private void Time_copy_calculate() {
            double sec;
            foreach (var ob in this.device)
            {
                sec = this.Work_computer / ob.infospeed;
               
                Console.WriteLine("Time for all copy all file is {0} sec for device {1} ",sec,ob.All_info());
               
            }
        }
        private void Quont_dev_calculate() {
            double item;
            foreach (var ob in this.device)
            {
                item = this.Work_computer / ob.Memory_capacity;
                if (item - Convert.ToInt32(item) > 0.0001)
                {
                    item = Convert.ToInt32(item);
                    item += 1;
                }
                Console.WriteLine("For total copy info you need {1} divices type:{0}",ob.All_info(),item);

            }

        }
        public Pr2() {
            this.device = new List<Storage>();
            this.info_for_copy= new double[725];
            for (int i = 0; i < info_for_copy.Length; i++)
            {
                if (i == 724)
                {
                    info_for_copy[i] = 280;

                }
                else
                {
               
                    
                    
                    info_for_copy[i] = 780;
                }
            }
            for (int i = 0; i < info_for_copy.Length; i++)
            {

                this.Work_computer += info_for_copy[i];
            }
        }


    }
}
