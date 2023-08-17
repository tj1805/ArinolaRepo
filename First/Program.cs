using First.AccessModifies;
using First.WorkingWithProeprties;
using System;


namespace First
{
    //aSSINGMENT STUDY THE application of a static Method
    //research hierachy
    ////Declare a proeperty of type int and the Name of the Property is "Polling Unit"
    //check the pollimh unit is less than 7
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Instantiate the Instance of Student
            Student myStudent = new Student();
            //Normal method without static
            myStudent.DoSomething();
            

            //Static, u can only access a static method using the Class Name
             
            Student.DoSomethinStatic();

            //Array
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            string[] b = new string[2] { "1", "r" };

            //pLAYING WITH cONSOLE IN OUR aPPLICATION
            PlayingWithConsole();


            //var maPP = new Program();
            //maPP.PlayingWithConsoleWithoutStatic();

            //Working with Access Modifiers
            // images/Handsomeboy.png
            Restaurant myRestaurant = new Restaurant();
            //it is a Public method
            myRestaurant.DoSomethingPublic();
            //Accessing the Proerprety
           var restaurantName = myRestaurant.RestaurantName;

            //default Access Mofifer
            Teacher myTeacher = new Teacher();


            //Working with properties
            Candidate myCandidate = new Candidate();
            //passs ina value to the age 
            // myCandidate.Age = 10;
          // Console.WriteLine(myCandidate.Age);
          
            myCandidate.SetAge(20);
            var ageOfMyCandidate = myCandidate.GetAge();
            Console.WriteLine($"the age of my candiate is {ageOfMyCandidate} ");

            //Using the shortCut Flow
            myCandidate.BVn = "12345";
            Console.WriteLine($"u ARE getting the Bvn{myCandidate.BVn}");
            //using shorteR method
            myCandidate.Address = "5, Amodu street";
            Console.WriteLine($"ur home address is {myCandidate.Address}");
            
        }

        static void PlayingWithConsole()
        {
            Console.WriteLine("Playing with Static in our Program.cs");
        }
         void PlayingWithConsoleWithoutStatic()
        {
            Console.WriteLine("Playing with Static in our Program.cs");
        }
    }
}
