using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise56_2_Moshcourse
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //2 - Write a program and ask the user to enter their name. Use an array to reverse
            //    the name and then store the result in a new string.Display the reversed name on the console.

            string name;
            Console.Write("Type your name ");
            name = Console.ReadLine();
            var r = name.ToArray();
            Array.Reverse(r);
            Console.WriteLine(r);



        }
    }
}
