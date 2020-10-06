using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class Student
    {
        public string IDStudent { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public double Medium { get; set; }

        public Student(){}

        public Student(string iDStudent, string fullName, DateTime dob, string gender, double medium)
        {
            IDStudent = iDStudent;
            FullName = fullName;
            Dob = dob;
            Gender = gender;
            Medium = medium;
        }

        public override string ToString() => $"id={IDStudent}, name={FullName}, birthday={Dob.ToShortDateString()}, gender={Gender}, medium score={Medium}";
    }
}
