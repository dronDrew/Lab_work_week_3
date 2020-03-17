using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_week_3
{
    class HDD:Storage
    {
        private double[] Quont_of_dir;
        public double speed_of_USB_2_0 { get; set; }
        public override string All_info()
        {
            return " Name "+this.name_storage + " Model " + this.Model_storage + " Memory " + this.Memory_capacity+" dir qount" + this.Quont_of_dir.Length+" free memory"+this.Memory_free + " Speed " + this.speed_of_USB_2_0;
        }
        public override void Copy_data_from(ref double memory_of_storage)
        {
            for (int i = 0; i < this.Quont_of_dir.Length; i++)
            {
               
                while (this.Quont_of_dir[i] > 0 && memory_of_storage > 0)
                {
                    if ((memory_of_storage - this.speed_of_USB_2_0) < 0)
                    {
                        this.Memory_free -= memory_of_storage;
                        this.Quont_of_dir[i] -= memory_of_storage;
                        memory_of_storage -= memory_of_storage;
                    }
                    else
                    {
                        memory_of_storage -= this.speed_of_USB_2_0;
                        this.Memory_free -= this.speed_of_USB_2_0;
                        this.Quont_of_dir[i] -= this.speed_of_USB_2_0;
                    }
                }
            }

        }
        public HDD(string Name, string model, double speed, int quont_dir) {
            this.name_storage = Name;
            this.Model_storage = model;
            this.speed_of_USB_2_0 = speed;
            this.infospeed = speed;
            this.Quont_of_dir = new double[quont_dir];
            for (int i = 0; i < this.Quont_of_dir.Length; i++) {
                Console.WriteLine("Enter memory size of {0} directory", i + 1);
                double res =Convert.ToInt32( Console.ReadLine());
                this.Quont_of_dir[i] = res;
                this.Memory_capacity += res;
            }
            this.Memory_free = this.Memory_capacity;
        }
    }
}
