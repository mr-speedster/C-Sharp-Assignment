using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    internal class College
    {
        public static int counter = 1000;
        private int collegeId;
        private string collegeName;

        public int CollegeId
        {
            get { return collegeId; }
            set { collegeId = value; }
        }
        public string CollegeName
        {
            get { return collegeName; }
            set { collegeName = value; }
        }
        public College()
        {

        }
        public College(string collegeName)
        {
            counter++;
            collegeId = counter;
            CollegeName = collegeName;
        }
    }
}
