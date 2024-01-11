using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student

    {
        public Student (string FullName,int Point)
        {
            this.Point = Point;
            this.FullName = FullName;
        }

        public Student (string FullName,int Point,string GroupNo) : this(FullName, Point)
        {
            this.GroupNo = GroupNo;
        }

        public Student (string Fullname,int Point,string GroupNo,DateTime BirthDay): this(Fullname, Point, GroupNo)
        {
            this.BirthDay = BirthDay;
        }




        public string FullName;
        public string GroupNo;
        public DateTime BirthDay;
        public int  Point;


        public void ShowStudents()
        {
            Console.WriteLine($"{this.FullName} - {this.GroupNo}-{this.BirthDay.ToString("dd.MM.yyyy")} - {this.Point}");


        }


        
    }
}
