using System;
using System.Collections.Generic;
using System.Text;

namespace Second.InterfaceFlow
{
    //DataAccessMongodB iMPLEMENT THE iNTERFACE istUDENTmANAGEMENT
    public class DataAccessMongoDb : IStudentManagement
    {
        public void CreateNewStudent()
        {
            //WRITE THE method Implementation
            Console.WriteLine("u are using MongoDb to create new studnet");
        }

        public void GetAllStudentInTheDatabase()
        {
            Console.WriteLine("u are using MongoDb gETaLLsTUDENT IN THE dATABASE");
        }

        public void GetAllStudnetTakingACourse()
        {
            Console.WriteLine("u are using MongoDb get all student taking a score");
        }

        public void GetStudentByMatricNumber()
        {
            Console.WriteLine("u are using MongoDb get all student By matirc Numeber");


        }
    }
}
