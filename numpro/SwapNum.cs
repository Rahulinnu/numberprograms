using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numpro
{
    public class SwapNum
    {
        

        public static void SwapN()
        {
            int first, second, temp;
            Console.WriteLine("PLease enter first digit: ");
            first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping");
            Console.WriteLine("first num" + first + "second num" + second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After swapping");
            Console.WriteLine("first num" + first + "second num" + second);

        }
    }
}
