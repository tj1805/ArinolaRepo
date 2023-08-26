using System;
using System.Collections.Generic;
using System.Text;

namespace Second.Inheritance
{
   public class Student
    {
        public int MatricNo { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        public void PaySchoolFees()
        {
            Console.WriteLine("Come anD Pay urnSchool Fees");
        }


       // 1.Prevent Certain members from being Inherited
       //2. changing certain beaviour from base class in derived class  virtual and overide Keyword
    }
}
