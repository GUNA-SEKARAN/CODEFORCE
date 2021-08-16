using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrong_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();
            string[] ans = input.Split();
            int n = Convert.ToInt32(ans[0]);
            int k = Convert.ToInt32(ans[1]);
            for (int i = 0; i < k; i++)
            {
              
                
                if (n % 10 == 0)
                {
                    n = n / 10;
                }
                else
                { 
                n--;
                }
                Console.WriteLine(n);
               

            }
          

        }
    }
}
