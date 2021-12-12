using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangingUsers
{
    internal class Student : User
    {
        int grade;

        public int Grade { get { return grade; } set { grade = value; } }
        public Student(string firstName, string lastName, int yearOfBirth, string email, int grade) : base(firstName, lastName, yearOfBirth, email)
        {
          this.grade = grade;
      
        }


        protected override void PrintAllDetail()
        {
            base.PrintAllDetail();
            Console.WriteLine($"first name: {this.FirstName}|| last name:{this.LastName}|| year of birth:{this.YearOfBirth}|| email:{this.Email}  grade:{this.grade}");
        }












    }


}
