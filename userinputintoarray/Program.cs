using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinputintoarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many integers will you enter? \n");

            string amount = Console.ReadLine();
            int arrayAmount = Convert.ToInt32(amount);
            int[] array = new int[arrayAmount];

            for(int i=0; i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The values you've entered are");
            Console.WriteLine("{0}{1,8}", "index", "value");
            for (int counter = 0; counter < array.Length; counter++)
                Console.WriteLine("{0,5}{1,8}", counter, array[counter]);
            Console.ReadLine();
        }
    }
}
