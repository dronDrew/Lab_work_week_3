using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_week_3
{
    class Range_array<T>
    {
        private int appertBound;
        private int lowerBound;
        private T[] arr;
        public Range_array() {
            this.lowerBound = 0;
            this.appertBound = 0;
            this.arr = null;
        }
        public Range_array(int LowerB,int UpperB) {
            if (UpperB < LowerB) {
                int res = LowerB;
                LowerB = UpperB;
                UpperB = res;
            }
            this.lowerBound = LowerB;
            this.appertBound = UpperB;
            this.arr = new T[appertBound - lowerBound];
        }
        public Range_array(int LowerB, int UpperB,T val)
        {
            if (UpperB < LowerB)
            {
                int res = LowerB;
                LowerB = UpperB;
                UpperB = res;
            }
            this.lowerBound = LowerB;
            this.appertBound = UpperB;
            this.arr = new T[appertBound - lowerBound];
            arr[0] = val;
        }
        public T this[int i] {
            get { 
                    return this.arr[i - this.lowerBound];
              
                    }
            set { this.arr[i-lowerBound] = value; }
        }
        public int Lenght() {
            return this.appertBound - this.lowerBound;
        }
        public void SetSize(int LowerB, int UpperB) {
            if (UpperB < LowerB)
            {
                int res = LowerB;
                LowerB = UpperB;
                UpperB = res;
            }
            this.lowerBound = LowerB;
            this.appertBound = UpperB;
            this.arr = new T[appertBound - lowerBound];
        }
        public int GetLowerBound() {
            return this.lowerBound;
        }
        public int GetUpperBound()
        {
            return this.appertBound;
        }
    }
}
