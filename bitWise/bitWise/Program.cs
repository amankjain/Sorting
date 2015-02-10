using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitWise
{
    class Program
    {
        public static uint swapByteOrder(uint value)
        {
            //http://stackoverflow.com/questions/5320439/how-do-i-swap-endian-ness-byte-order-of-a-variable-in-javascript

            //text file in project has content of above link
            return value;

        }
        static void Main(string[] args)
        {
              /*
             * Set union
A | B
Set intersection
A & B
Set subtraction
A & ~B
Set negation
ALL_BITS ^ A
Set bit
A |= 1 << bit
Clear bit
A &= ~(1 << bit)
Test bit
(A & 1 << bit) != 0
             * */
            //Test A bit
      //      int A = 55;
        //    bool 4thBitValueIsFalse = ((A & (1 << 4)) == 0);

          

            //big endian to little endian
      /*      i = (data[0]<<0) | (data[1]<<8) | (data[2]<<16) | (data[3]<<24);
If it's big-endian, here's how to extract it:
i = (data[3]<<0) | (data[2]<<8) | (data[1]<<16) | (data[0]<<24);
            */


        }
    }
}
