using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 11, 4, 5, 6, 7, 3, 7 };
            Array.Sort(array);
            Array.Reverse(array);
            var result = array[0] + array[1];
            return result;
            Console.WriteLine(result);
        }
    }
}
