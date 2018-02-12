﻿using System;
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
             * Hello Guys,

In respect to the current topic you all should attempt the following excercise

1) Declare a Math class that has 4 non-static methods Add, Substract, Multiply & Divide,
each of which takes 2 parameters. Call each method from the Main() and output the their result to the console window.
3) Modify the program from Exercise 1 so that you do not have to create an instance of Math
to call the four methods
4) Add a constructor to the Math class this constructor will take 2 parameters 
(Int32 param1 & Int32 param2) assign these parameters to 2 global fields (Int32 param1; Int32 _param2)

I expect you all to create a repo on your GitHub account and push this excercise to it will check it 
on Tuesday when am around.

Happy Coding!!!

Prolifik Lexzy

Code Instructor.
             * */
            Console.WriteLine("Enter first value");
            int v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second value");
            int v2 = Convert.ToInt32(Console.ReadLine());

            int result=0;
            MathClass MC = new MathClass();
            
            char select;
            Console.Write("Enter A for Addition, S for subtraction, M for multiplication, D for divide");
            select =Convert.ToChar(Console.ReadLine());

            switch(select)
            {
                case 'a':
                case 'A':
                   result= MC.Addition(v1,v2);
                    break;

                case 's':
                case 'S':
                   result= MC.Subtract(v1,v2);
                    break;
                case 'm':
                case 'M':
                    result=MC.Multiply(v1,v2);
                    break;
                case 'd':
                case 'D':
                   result= MC.Division(v1,v2);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
