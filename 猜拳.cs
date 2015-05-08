using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請決定您要出的拳(ex: 剪刀=1、石頭=2、布=3):");
            int a = int.Parse(Console.ReadLine());
            Random random = new Random();
            int x;
            x = random.Next(1, 4);
            int b = a - x;
            if (b == -1 || b == 2)
                Console.WriteLine("你輸了！");
            else if (b == 1 || b == -2)
                Console.WriteLine("你贏了！");
            else
                Console.WriteLine("平手！");
        }
    }
}