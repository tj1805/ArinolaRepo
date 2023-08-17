using System;
using System.Collections.Generic;
using System.Text;

namespace First.AccessModifies
{
    //encapsulation is basicaly data hiding, wat do we use to hide data. we use access Modifeiers
    //Acess Modifeirs in c#
   //Public
   //private
   //Protected
   //internal
   //protected internal



    public class Restaurant
    {
        public string RestaurantName;
        private string SecretRecipe;
        //A public ,ethod is a method that is accesbile everywehre in our application
        public void DoSomethingPublic()
        {
            Console.WriteLine("We are doing Something public ");
           
        }
        //A private method is a method that is  only accesbile only in the application that is decalred
        private void DoSomethingSecret()
        {
            Console.WriteLine("We are doing Something Secret");
        }
        //I can call a Private method anywhere in the classs dat  it is Declared 
        public void ApublicMethodCallingAprivateMethodWithingTheClass()
        {
            Console.WriteLine("ApublicMethodCallingAprivateMethodWithingTheClass");
            DoSomethingSecret();
        }

        public void AccessingProperties()
        {
            Console.WriteLine($"We are getiing public poeprties {RestaurantName} + {SecretRecipe} ");

        }
    }
}
