using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Student : IEnrollable
    {
        private int ID { get; set; }
        public string Name { get; set;}
        public string Subject { get; set; }
        public int HomeNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public StudentStatus Status { get; set; }

        public override string ToString()
        {
            return string.Format($"{ID}, {Name}, {Subject},{HomeNo},{Street},{City},{PostCode},{Status}");
        }

        public void Enrol()
        {
            Status = (StudentStatus)1;
        }

        public Student(int id, string name, string subject, int homeNo, string street,
            string city, string postCode, StudentStatus status)
        {
            ID = id;
            Name = name;
            Subject = subject;
            HomeNo = homeNo;
            Street = street;
            PostCode = postCode;
            City = city;
            Status = status;
        }

        public Student()
        {
        }
    }
}
