using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fullname daxil edin :");
            string FullName1 = Console.ReadLine();
            Console.WriteLine("Point daxil edin :");
            string point1Str = Console.ReadLine();
            int point1 = Convert.ToInt32(point1Str);
            Console.WriteLine("grup nomresini daxil edin :");
            
            Student student = new Student(FullName1, point1)
            {
                
                GroupNo = Console.ReadLine(),
                
            };

            student.ShowStudents();





        }
    }
}
