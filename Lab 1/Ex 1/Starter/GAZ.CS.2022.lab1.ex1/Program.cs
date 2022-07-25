using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAZ.CS._2022.lab1.ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            while ((line = Console.ReadLine()) != null)
            {
                line = line.Replace(",", " y:");
                line = "x:" + line;
                Console.WriteLine(line);
            }

           
        }
    }
}
