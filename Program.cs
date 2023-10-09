using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        { // you can just print numbers as below
            Console.WriteLine(7);
                // You can also use operators + * /
                Console.WriteLine(6+7);
            // modulo operators to get the remaining 
            Console.WriteLine( 8%3);
            // Bodmas will applies, 4+2+3 use the brackets
            Console.WriteLine(4+2+3);
            // whatever you do with integers you get an integr back
            Console.WriteLine(5/3); // you get 2 not 2,5
            // if you use a decimal and an integer you get a doube
            Console.WriteLine(5/2.0); // you get 2,5
            // Can also give a number to a variable
            int num = 6;
            //increment or decrement by 1
            num++;
             
            Console.WriteLine(num);
            //calling eg math method ,abs means absolute
            //  you will always get the positive number
            Console.WriteLine(Math.Abs(-40));
            // to raise to powers
            Console.WriteLine(Math.Pow(2,2));



        }
    }
}
