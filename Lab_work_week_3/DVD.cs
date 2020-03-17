using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_week_3
{
    class DVD:Storage
    {
        private string Type_side;
        public override string All_info()
        {
            return "Name "+this.name_storage + " Model " + this.Model_storage + " Memory" + this.Memory_capacity + " Free memory " + this.Memory_free+" speed"+this.speed_wr_and_rd;
        }
        public override void Copy_data_from(ref double memory_of_storage)
        {
            while (Memory_free > 0 && memory_of_storage > 0)
            {
                if ((memory_of_storage - this.speed_wr_and_rd) < 0)
                {
                    this.Memory_free -= memory_of_storage;
                    memory_of_storage -= memory_of_storage;
                }
                if ((Memory_free - this.speed_wr_and_rd) < 0)
                {
                    break;
                }
                memory_of_storage -= this.speed_wr_and_rd;
                this.Memory_free -= this.speed_wr_and_rd;
            }
        }
        public double speed_wr_and_rd { get; set; }
        public DVD(string Name,string Model,double speed_r_w,string type) {
            this.speed_wr_and_rd = speed_r_w;
            this.name_storage = Name;
            this.Model_storage = Model;
            this.infospeed = speed_r_w;
            if (type == "oneside"|| type == "Oneside"|| type == "ONESIDE"|| type == "OneSide") {
                this.Memory_capacity = 4700;
                this.Memory_free = this.Memory_capacity;
                this.Type_side = type;

            } else if (type == "twoside" || type == "Twoside" || type == "TWOSIDE" || type == "TwoSide") {
                this.Memory_capacity = 9000;
                this.Memory_free = this.Memory_capacity;
                this.Type_side = type;
            }
            else {
                this.Memory_capacity = 4700;
                this.Memory_free = this.Memory_capacity;
                this.Type_side = type;
            }
        
        }
    }
}
