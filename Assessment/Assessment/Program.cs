using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public enum StudentStatus { None, Enrolled, InTraining, CompletedTraining };
    class Program
    {
        string path = System.IO.File.ReadAllText(@"C:\Users\Manish\Documents\Manish Apprenticeship\QA\Blocks QA\QA C#\Block 2\Students.txt");
        
        static void Main(string[] args)
        {
            Student stu = new Student();                      

            QA qA = new QA();

            foreach (var student in qA.GetStudents())
            {
                Console.WriteLine(student);

                if (student is ManagementStudent)
                {                   
                    ((ManagementStudent)student).WriteReport();
                }
            }
            Console.WriteLine();
            var Completed = qA.GetStudents().Where(n=>n.Status == ((StudentStatus)3));
            foreach (var item in Completed.ToList())
            {
               
                Console.WriteLine(item);
            }

            //using interface enrol 
            Console.WriteLine();
            var inter = qA.GetStudents().Where(n => n.Status == 0);
            foreach (var item in inter.ToList())
            {
                item.Enrol();
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var Enrolled = qA.GetStudents().Where(n => n.Status == (StudentStatus.Enrolled));
            foreach (var item in Enrolled.ToList())
            {

                Console.WriteLine(item);
            }


        }
    }
}
