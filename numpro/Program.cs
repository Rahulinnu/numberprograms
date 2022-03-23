using System;
using System.Text;
using System.Threading.Tasks;

namespace numpro
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please choose number to execute");
            Console.WriteLine("1:Fibonacci\n2:Reverse number\n3:Swap numbers\n4:Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Fibonacci.Series();
                    break;

                case 2:
                    ReverseNumber.FindReverseNumber(26);
                    break;

                case 3:
                    SwapNum swap = new SwapNum();
                    SwapNum.SwapN();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadLine();
        }
    }
}
