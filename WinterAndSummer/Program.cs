using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterAndSummer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testData1 = { 5, -2, 3, 8, 6 };
            int[] testData2 = { -5, -5, -5, -42, 6, 12 };
            Solution sln = new Solution();
            Console.WriteLine(sln.WinterAndSummer(testData1));
            Console.WriteLine(sln.WinterAndSummer(testData2));
            Console.ReadKey();
        }
    }
}
