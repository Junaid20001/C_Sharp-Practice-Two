using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Junaid";
            string fthr_name = "   Khalid  ";
            string salaam = "Assalam o Alikum";
            Console.WriteLine(name + " " + salaam);
            Console.WriteLine($"My Name is : {name} Your Welcome with {salaam}");
            Console.WriteLine($"My Name is: {name}\nYour Name length is {name.Length}");
            Console.WriteLine($"My Father Name is: {fthr_name.Trim()} ..use full trim method \n");
            Console.WriteLine($"My Father Name is: {fthr_name.TrimStart()}\n use start trim \n {fthr_name.TrimEnd()} end trim method  ");
            Console.WriteLine($"My name length is {name.Length} and my father name length is {fthr_name.Length}");
            Console.WriteLine("\n" + $"My Name is : {name.Contains("Faiz")} & I  am not a Terrorist");

            /*
             int x=2;
             x++; //++ is a unary operator and x is an operand
             x--; //-- is a unary operator
             x = -3*x; //- is a unary operator

             */

            /*
            int x, y, z;
            x = 15; y = 6;

            z = x + y;  // + is a binary operator
            Console.WriteLine("The Sum means add of " + x + " & " + y + " is " + z);

            z = x - y;  // - is a binary operator
            Console.WriteLine("The difference means minus of " + x + " & " + y + " is " + z);

            z = x * y;  // * is a binary operator
            Console.WriteLine("The product means multiply of " + x + " & " + y + " is " + z);

            z = x / y;  // / is a binary operator
            Console.WriteLine("The quotient means divide of " + x + " & " + y + " is " + z);

            z = x % y;  // % is a binary operator
            Console.WriteLine("The modulus/remainder means percentage of " + x + " & " + y + " is " + z);
            */

            /*
            int age;
            Console.WriteLine("Your age is : ");
            age = Convert.ToInt32(Console.ReadLine());
            string ternary = age >= 18 ? "Eligible" : "Not Eligible";
            Console.WriteLine("You are " + ternary);
            */

            /*Rational Operator
            int x, y;
            Console.WriteLine("Enter first number x : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first number y : ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" {0} > {1} = {2}", x, y, x > y);
            Console.WriteLine(" {0} < {1} = {2}", x, y, x < y);
            Console.WriteLine(" {0} >= {1} = {2}", x, y, x >= y);
            Console.WriteLine(" {0} <= {1} = {2}", x, y, x <= y);
            Console.WriteLine(" {0} != {1} = {2}", x, y, x != y);
            Console.WriteLine(" {0} == {1} = {2}", x, y, x == y);
            */
            /* Logical Operator
            int x, y,z;
            Console.WriteLine("Enter first number x : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first number y : ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first number z : ");
            z = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0} > {1} AND {2} > {3} = {4}", x, y, x, z, (x>y && x>z));
            Console.WriteLine("{0} > {1} OR {2} > {3} = {4}", x, y, x, z, (x > y || x > z));
            Console.WriteLine("{0} > {1} = {2}", x, y,!(x>y));

            /* Assignment Operator
            int x = 10;

            //x = x + 10;
            x += 10;

            //x = x - 10;
            x -= 10;

            //x = x * 10;
            x *= 10;

            //x = x / 10;
            x /= 10;

            //x = x % 10;
            x %= 10;
            Console.WriteLine(x);  
            */


            /* BitWise Operator
             int x =25; int y =34;
            
            Console.WriteLine(" {0} & {1} = {2}", x, y, x & y);
            Console.WriteLine(" {0} | {1} = {2}", x, y, x | y);
            Console.WriteLine(" {0} ^ {1} = {2}", x, y, x ^ y);
            Console.WriteLine(" {0} >> {1} = {2}", x, y, x >> y);
            Console.WriteLine(" {0} << {1} = {2}", x, y, x << y);
             */



            Console.ReadLine();
        }
    }
}
