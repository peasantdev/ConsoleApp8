using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instantiated employee ids with input.
            Employee id1 = new Employee(9);
            Employee id2 = new Employee(10);

            if (id1 == id2)
                Console.WriteLine("Equal");
            else Console.WriteLine("Not Equal");
            Console.ReadLine();
        }
    }
}
