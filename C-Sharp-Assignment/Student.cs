using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    delegate void StudentDelegate (Student student);
    internal class Student
    {
        private double collegeFees;
        private char gender;
        private int marks;
        private bool sportsQuota;
        private string studentName;

        public double CollegeFees
        {
            get { return collegeFees; }
            set { collegeFees = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        public bool SportsQuota
        {
            get { return sportsQuota; }
            set { sportsQuota = value; }
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public Student()
        {

        }
        public Student(string studentName, int marks, char gender, bool sportsQuota)
        {
            StudentName = studentName;
            Marks = marks;
            Gender = gender;
            SportsQuota = sportsQuota;
        }
    }
}
