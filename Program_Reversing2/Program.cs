using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Reversing2
{
    class Program
    {
        static void Main(string[] args)
        {

            string str;
            int l = 0;

            Console.WriteLine("\n\nprint individual characters of string in reverse order :\n");
            Console.WriteLine("------------------------------------------------------\n");
            Console.WriteLine("Input the string : ");
            str = Console.ReadLine();

            l = str.Length - 1;
            Console.WriteLine("The characters of the string in reverse are : \n");
            while (l >= 0)
            {
                Console.WriteLine("{0} ", str[l]);
                l--;
            }
            Console.WriteLine("\n\n");
            Console.ReadLine();


        }

    }
}
