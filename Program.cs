using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 0;
            bool countingStarted = false;

            for (int i = s.Length-1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    count++;
                    countingStarted = true;
                }
                else if (!countingStarted)
                {
                    count = 0;
                }
                else 
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
