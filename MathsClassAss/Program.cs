using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsClassAss
{
    class Program
    {
        static void Main(string[] args)
        {
        /*

Main Method
*/
        DoAgain:
            Console.WriteLine("WELCOME TO MATHEMATICS BASIC OPERATION CLASS\n");
            Console.WriteLine("Enter first value");
            int v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second value");
            int v2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            char select;

            Console.Write("Enter S for static and N for non-static : ");
            select = Convert.ToChar(Console.ReadLine());
            switch (select)
            {
                case 'S':
                case 's':
                    MathsNon_static calc = new MathsNon_static(v1,v2);
                    int i;
                    Console.WriteLine("select 1) for addition 2) subtraction 3)multiplication 4)division");
                    i = Convert.ToChar(Console.ReadLine());
                    if (i == '1')
                    {
                       result= calc.Addition(v1, v2);
                    }
                    else if (i == '2')
                    {
                        result = calc.Subtract(v1, v2);
                    }
                    else if (i == '3')
                    {
                        result = calc.Multiply(v1, v2);
                    }
                    else if (i == '4')
                    {
                        result = calc.Division(v1, v2);
                    }
                    else
                    {
                        Console.Write("Wrong input");
                    }
                    break;
                case 'N':
                case 'n':
                    char j;
                    Console.WriteLine("select 1) for addition 2) subtraction 3)multiplication 4)division");
                    j = Convert.ToChar(Console.ReadLine());
                    if (j == '1')
                    {
                        result = MathClass.Addition(v1, v2);
                    }
                    else if (j == '2')
                    {
                        result = MathClass.Subtract(v1, v2);
                    }
                    else if (j == '3')
                    {
                        result = MathClass.Multiply(v1, v2);
                    }
                    else if (j == '4')
                    {
                        result = MathClass.Division(v1, v2);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }           
                    
            Console.WriteLine(result);
            char choice;
            Console.Write("Y to doagain, N to exit");
            choice = Convert.ToChar(Console.ReadLine());
            
            if(choice=='y'||choice=='Y')
            {
                Console.Clear();
                goto DoAgain;
            }
            else if (choice=='N' || choice=='n')
            {
                goto Finish;
            }
            else
            {
                Console.WriteLine("wrong input");
            }

            Finish: Console.WriteLine("anykey to exit");
            Console.ReadKey();

        }
        
    }
}
