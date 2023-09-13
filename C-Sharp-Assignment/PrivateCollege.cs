using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    internal class PrivateCollege : College
    {
        private int donation;
        private Address privateCollegeAddress;

        public int Donation
        {
            get { return donation; }
            set { donation = value; }
        }
        public Address PrivateCollegeAddress
        {
            get { return privateCollegeAddress; }
            set { privateCollegeAddress = value; }
        }
        public PrivateCollege()
        {

        }
        public PrivateCollege(string collegeName, int donation, Address privateCollegeAddress) : base(collegeName)
        {
            Donation = donation;
            PrivateCollegeAddress = privateCollegeAddress;
        }
        public void CalculateFees(Student student)
        {
            if (student.Marks > 75 && Donation > 100000)
            {
                student.CollegeFees = 75000 - (Donation * 0.5);
            }
            else
            {
                student.CollegeFees = 75000;
            }
        }
    }
}
