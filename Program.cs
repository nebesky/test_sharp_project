using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            int num;
            bool isNum = int.TryParse(str, out num);
            if (isNum)
            {
                Console.WriteLine("Это число");
                var list = new List<int>();
                for (var i = 0; i < 10; i++)
                {
                    list.Add(i);
                }

                for (var i = 0; i < list.Count; i++)
                {
                    var fact = (i++);
                }

            }

            else
                Console.WriteLine("Попробуйте снова:");
        }
    }
}
