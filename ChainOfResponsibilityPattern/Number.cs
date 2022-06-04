using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal class Number
    {
        private int number;

        public Number(int number)
        {
            this.number = number;
        }

        public int getNumber()
        {
            return number;
        }
    }
}
