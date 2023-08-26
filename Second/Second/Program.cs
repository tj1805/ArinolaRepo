using Second.Inheritance;
using Second.RelationShip;
using System;

namespace Second
{

    //first Assignment in c# using visula studion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var demoStudent = new PartTimeStudent();
            demoStudent.Course = "Demo";
            demoStudent.MatricNo = 1234;
            demoStudent.Name = "shsj";
            demoStudent.PaySchoolFees();
            var postStudent1 = new PostGraduateStudent();

            //It is in the Student base Class
            postStudent1.Course = "ELECT";
            //It is in the Student base Class
            postStudent1.MatricNo = 12234;
            //It is in the Student base Class
            postStudent1.Name = "Ola";
            //It is in the Student base Class
            postStudent1.PaySchoolFees();

            postStudent1.ProjectSuperVisor = "arin";

           postStudent1.StudentHostel = new Hostel() { HallMaster ="Greatest Showman,", HostelName="BioBaku"};
            postStudent1.GetStudentHostel();
             
          

        }
    }
}
//A studnet Managemnt application
//we are going to have 3 studnet category, Undergraduate, Postgraduate, Partime