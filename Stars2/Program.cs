using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i, j, k;
            for (i = 0; i < n+1; i++)
            {
                for (j = 0; j < n - i; j++)
                    Console.Write(" ");
                for (k = 0; k < 2 * i - 1; k++)
                    Console.Write("*");
                Console.Write("\n");
            }

            int count = 0;
            
            for (j = 0; j <= n+1; j++){
                for (k = 0; k < count + 1; k++)
                    Console.Write(" ");
                count++;
                for (k = 0; k < 2*(n - j)-3; k++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
