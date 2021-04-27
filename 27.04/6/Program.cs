using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 1;
            for (int i = 3; i <= 24; i=i+3)
            {
               
                s = s*2;
            }
            
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
