using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** CALCULATOR *****");

            Console.WriteLine("Enter Any Operator");
            string opt = Console.ReadLine();

            Console.WriteLine("Enter First Number");
            int firstNnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Secound Number");
            int secoundNumber = int.Parse(Console.ReadLine());
            
            
            switch (opt)
            {
                case "+":
                    int add = firstNnumber + secoundNumber;
                    Console.WriteLine("Sum :{0}",add);
                    break;

                case "-":
                    int sub = firstNnumber - secoundNumber;
                    Console.WriteLine("sub :{0}", sub);
                    break;

                case "*":
                    int multi = firstNnumber * secoundNumber;
                    Console.WriteLine("multi :{0}",multi);
                    break;

                case "/":
                    int divi= firstNnumber / secoundNumber;
                    Console.WriteLine("divi :{0}",divi);
                    break;

                case "%":
                    int per = (firstNnumber * 100) / secoundNumber;
                    Console.WriteLine("pers :{0}",per);
                    break;


                default:
                    Console.WriteLine("invalid operator");
                    break;
            }
        }
    }
}
