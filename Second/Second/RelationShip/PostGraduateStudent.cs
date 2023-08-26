using Second.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Second.RelationShip
{
    //Interface relatioship
    public class PostGraduateStudent : Student
    {
        //string is the DataType
        //project is the property

        public string ProjectSuperVisor { get; set; }
        //hostel is the Dattype
        //a psotgraduate student has A Hostel
        public Hostel StudentHostel { get; set; }

        public void GetStudentHostel()
        {
            
            Console.WriteLine(StudentHostel.HostelName);
        }
    }
}
