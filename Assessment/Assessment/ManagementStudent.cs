using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class ManagementStudent :Student
    {
        public ManagementStudent()
        {
        }

        public ManagementStudent(int id, string name, string subject, int homeNo, string street, string city, string postCode, StudentStatus status) : base(id, name, subject, homeNo, street, city, postCode, status)
        {
        }

        public void WriteReport() {
            Console.WriteLine("This is the Write Report Method");

        }
    }
}
