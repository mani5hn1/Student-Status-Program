using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusProg
{
    class SchoolStudents
    {
        private List<Student> students;

        public SchoolStudents()
        {
            students = new List<Student>();
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\Manish\Documents\Students.txt");
            while ((line = file.ReadLine()) != null)
            {
              string [] split =  line.Split(',');

            students.Add(new Student(int.Parse(split[0]),split[1],split[2],
                    int.Parse(split[3]),split[4], split[5],split[6], (StudentStatus)int.Parse(split[7])));
            }

            file.Close();
            
            ManagementStudent manstu = new ManagementStudent(51,"Manish","C#",60,"Ashton Road","London","E15 1DP", (StudentStatus)2);
            ManagementStudent manstuNext = new ManagementStudent(52, "Manish", "C++", 40, "Ash Road", "London", "E17 17P", (StudentStatus)3);

            AddStudent(manstu);
            AddStudent(manstuNext);
        }
            public List<Student> GetStudents()
            {
                return students;
            }

            public void AddStudent(Student student)
            {
                students.Add(student);
            }
        }
    }

