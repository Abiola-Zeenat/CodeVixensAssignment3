using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWD_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring and Assigning Variables
           int myWholeNum = 15;

           double myDecimal = 7.56;

           char myAlphabet = 'A';

           bool isJavascriptEasy = false;

           string myName = "Abiola Abdulsalam";

            Console.WriteLine($"{ myName} is a coding mom");


            //Arithmetic operators
            int sum = 10 + myWholeNum; //Addition

            int subtract = (int) myDecimal - 5;  //Subtraction

            int multiply = subtract * 6;  //Multiplication

            double divide = sum / myDecimal; //Division

            int module = multiply % 5; //modulus
            int x = 5, y = 8;

            Console.WriteLine(sum);
            Console.WriteLine(subtract);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);
            Console.WriteLine(module);
            Console.WriteLine(x++);  // Increment
            Console.WriteLine(y--);  //Decrement


            //Assignment operators

            Console.WriteLine(x += y); 
            Console.WriteLine(y -= x);
            Console.WriteLine(x *= 3);
            Console.WriteLine(y /= 2);
            Console.WriteLine(x %= 2);


            //Comparison Operators

            bool equal = (sum == y);
            Console.WriteLine(isJavascriptEasy == equal);// equal to

            Console.WriteLine(subtract != x);  //Not equal

            Console.WriteLine(multiply > y);  //Greater than

            Console.WriteLine(divide < myDecimal); //Less than

            Console.WriteLine(module >= x); //Greater than or equal to

            Console.WriteLine(x <= y);  //Less than or equal to


            //Logical Operator

            Console.WriteLine(x < 9 && y > 2); //Logical and

            Console.WriteLine(x < 5 || y < 4);  //Logical or

            Console.WriteLine(!(x < 5 && y > 10));  //Logical not


            //Math 

            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Round(myDecimal));
            Console.WriteLine(Math.Abs(-4.32));
            Console.WriteLine(Math.Sqrt(49));
            Console.WriteLine(Math.Floor(divide));

        }
    }
}
