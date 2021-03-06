﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_week_3
{
    class Flash:Storage
    {
        public override void Copy_data_from( ref double memory_of_storage)
        {
            while (Memory_free > 0&&memory_of_storage>0) {
                if ((memory_of_storage - this.speed_of_USB_3_0) < 0)
                {
                    this.Memory_free -= memory_of_storage;
                    memory_of_storage -= memory_of_storage;
                }
                if ((Memory_free -  this.speed_of_USB_3_0) < 0) {
                    break;
                }
                memory_of_storage-=this.speed_of_USB_3_0;
                this.Memory_free -=this.speed_of_USB_3_0;
            }
        }
        public override string All_info()
        {
            return " Name "+this.name_storage+" Model "+this.Model_storage+" Memory "+ this.Memory_capacity + " Free memory" + this.Memory_free + "  speed "+this.speed_of_USB_3_0; 
        }

        public double speed_of_USB_3_0 { get; set; }

        public Flash(string name, string model, double Memory_cop, double speed) {
            this.name_storage = name;
            this.Model_storage = model;
            this.Memory_capacity = Memory_cop;
            this.Memory_free = Memory_cop;
            this.speed_of_USB_3_0 = speed;
            this.infospeed = speed;
        }
    }
}
