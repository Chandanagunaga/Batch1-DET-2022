using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class LINQOrderByDescending
    {
        public static void Main()
        {
            string[] names = { "chandana", "saroja", "bharati","tara" };

            var result = names.OrderByDescending(n => n);

            Console.WriteLine("Descending ordered list of names:");
            foreach (string name in result)
                Console.WriteLine(name);
        }
    }
}
