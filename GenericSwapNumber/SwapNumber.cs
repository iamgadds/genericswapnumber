using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapNumber
{
    public class SwapNumber<UNKNOWNDATATYPE>
    {
        public UNKNOWNDATATYPE number1 { get; set; }
        public UNKNOWNDATATYPE number2 { get; set; }
        public void swap()
        {
            UNKNOWNDATATYPE number3 = number1;
            number1 = number2;
            number2 = number3;
        }
    }
}
