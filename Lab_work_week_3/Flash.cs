using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_week_3
{
    class Flash:Storage
    {
        public override void Copy_data_from( ref int memory_of_storage)
        {
            while (Memory_free > 0) {
                if ((Memory_free - (780 * this.speed_of_USB_3_0)) < 0) {
                    break;
                }
                memory_of_storage-= (780*this.speed_of_USB_3_0);
                this.Memory_free -= (780*this.speed_of_USB_3_0);
            }
        }
        public override string All_info()
        {
            return this.name_storage+" "+this.Model_storage+" "+ this.Memory_capacity + " " + this.Memory_free + " "+this.speed_of_USB_3_0; 
        }

        public int speed_of_USB_3_0 { get; set; }

        public Flash(string name, string model, double Memory_cop, int speed) {
            this.name_storage = name;
            this.Model_storage = model;
            this.Memory_capacity = Memory_cop;
            this.Memory_free = Memory_cop;
            this.speed_of_USB_3_0 = speed;
        }
    }
}
