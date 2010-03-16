using System;
using TemplatePattern.Framework;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var houseBlend = new HouseBlend();
            houseBlend.Prepare();

            Console.ReadLine();

            var darkRoast = new DarkRoast();
            darkRoast.Prepare();

            Console.ReadLine();
        }
    }
}
