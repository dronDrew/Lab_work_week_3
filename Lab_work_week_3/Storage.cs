using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_week_3
{
      abstract class Storage
    {
        protected string name_storage;
        protected string Model_storage;
        public abstract string All_info();
        public abstract void Copy_data_from( ref int  memory_of_storage);
        public double Memory_capacity { get; set; }
        public double Memory_free { get; set; }

    }
}
