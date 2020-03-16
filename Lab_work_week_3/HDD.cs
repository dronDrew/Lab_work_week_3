using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_week_3
{
    class HDD:Storage
    {
        private int[] Quont_of_dir;
        public int speed_of_USB_2_0 { get; set; }
        public override string All_info()
        {
            return this.name_storage + " " + this.Model_storage + " " + this.Memory_capacity+" " + this.Quont_of_dir.Length + " " + this.speed_of_USB_2_0;
        }
        public override void Copy_data_from(ref int memory_of_storage)
        {
            for (int i = 0; i < this.Quont_of_dir.Length; i++)
            {
               
                while (this.Quont_of_dir[i] > 0 && memory_of_storage > 0)
                {
                    if ((this.Quont_of_dir[i] - this.speed_of_USB_2_0) < 0)
                    {
                       
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
        public HDD(string Name, string model, int speed, int quont_dir) {
            this.name_storage = Name;
            this.Model_storage = model;
            this.speed_of_USB_2_0 = speed;
            this.Quont_of_dir = new int[quont_dir];
            for (int i = 0; i < this.Quont_of_dir.Length; i++) {
                Console.WriteLine("Enter memory size of {0} directory", i + 1);
                int res =Convert.ToInt32( Console.ReadLine());
                this.Quont_of_dir[i] = res;
                this.Memory_capacity += res;
            }
            this.Memory_free = this.Memory_capacity;
        }
    }
}
