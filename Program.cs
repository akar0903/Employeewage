using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wage = Console.ReadLine();
            string hour = Console.ReadLine();
            Console.WriteLine((Convert.ToInt32(wage) * (Convert.ToInt32(hour))));
            Console.ReadLine();
        }
    }
}
