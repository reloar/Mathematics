using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsClassAss
{
    class MathsNon_static
    {
        private int v1;
        private int v2;
        public MathsNon_static(int param1, int param2)
        {
            v1 = param1;
            v2 = param2;

        }

            public  int Addition(int value1, int value2) 
            {
                int Add = value1 + value2;
                return (Add);
            }

            //Maths Subtraction
            public  int Subtract(int value1, int value2)
            {

                int Sub = value1 - value2;
                return (Sub);
            }

            //Maths Multiplication
            public  int Multiply(int value1, int value2)
            {
                int Times = value1 * value2;
                return (Times);
            }

            //Maths Divsion
            public  int Division(int value1, int value2)
            {
                int divide = value1 / value2;
                return (divide);
            }

        }

   
}
