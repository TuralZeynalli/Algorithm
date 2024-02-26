using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           int tree = TreeDevelopment(3);
            Console.WriteLine(tree);
           


        }


        public static int TreeDevelopment(int period) 
        
        {
            int length = 0;

            for (int i = 0; i <= period; i++)
            {

                if (i % 2 == 0)
                {
                    length += 1; 
                }
                else
                {
                    length *= 2; 
                }

            }
            return length;
        }
    }
}
