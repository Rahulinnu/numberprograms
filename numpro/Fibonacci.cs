using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numpro
{
    public class Fibonacci
    {
        public static void Series()
        {
            int first=0, second=1, res = 0;
            int length = 0;
            Console.WriteLine("Please write n value for fibonacci series ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write(first + "" + second);

            Console.Write(" " + res);
            for(int i =1; i<=10; i++)
            {
                first = second;
                second = res;
                res = first + second;
                Console.Write(" " + res);

            }
        }
    }
}
