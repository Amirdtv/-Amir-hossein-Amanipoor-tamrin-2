using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 adad vared konin : ");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int y;
            y = Convert.ToInt32(Console.ReadLine());
            int z;
            z = x + y;
            System.Console.WriteLine(z);
            System.Console.ReadKey();
        }
    }
}
