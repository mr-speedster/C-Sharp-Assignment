using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    internal class GovtCollege: College
    {
        private Address govtCollegeAddress;
        public Address GovtCollegeAddress
        {
            get { return govtCollegeAddress; }
            set { govtCollegeAddress = value; }
        }
        public GovtCollege()
        {

        }
        public GovtCollege(string collegeName, Address address): base(collegeName)
        {
            GovtCollegeAddress = address;
        }
        public void CalculateFeesBasedOnMarks(Student studentObj)
        {
            if (studentObj.Marks >= 80)
            {
                studentObj.CollegeFees = 20000;
            }
            else
            {
                studentObj.CollegeFees = 35000;
            }
        }
        public void CalculateFeesBasedOnSportsQuota(Student studentObj)
        {
            if (studentObj.SportsQuota)
            {
                studentObj.CollegeFees -= 5000;
            }
        }
        public void SetFees(Student studentObj)
        {
            StudentDelegate studentDelegate = new StudentDelegate(CalculateFeesBasedOnMarks);
            studentDelegate += CalculateFeesBasedOnSportsQuota;
            studentDelegate(studentObj);
        }
    }
}
