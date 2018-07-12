using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); //default constructor

            Student student1 = new Student("John", "Doe");//overloaded constructor
            Console.WriteLine(student1.GetFullName());
        }
    }
}
