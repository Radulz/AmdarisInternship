using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAssignment
{
    class SomeClass
    {
        private int number;
        private double fractional;
        public SomeClass(int nr, double fr)
        {
            this.number = nr;
            this.fractional = fr;
        }

        public double sum()
        {
            return this.number + this.fractional;
        }
    }
}
