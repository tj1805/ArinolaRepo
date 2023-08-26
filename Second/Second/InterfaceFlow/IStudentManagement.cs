using System;
using System.Collections.Generic;
using System.Text;

namespace Second.InterfaceFlow
{
    //public is an accessModifer is
    //interface is a Keyword similar to class
    //IstudentManagement is the Interface name

    //in c# an Interface does not contain method implentation
  public  interface IStudentManagement
    {
        //no need for access modifier
        //GetStudentBy MatricNumber
        //an interface does not have a method Implementation
        void GetStudentByMatricNumber();
        //GetAllStudnet in the Database
        void GetAllStudentInTheDatabase();
        //CreateAnewStudent
        void CreateNewStudent();
        //GetAllStudnet taking a Course
        void GetAllStudnetTakingACourse();
    }
}
