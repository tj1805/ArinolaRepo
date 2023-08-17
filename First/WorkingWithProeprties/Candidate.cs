using System;
using System.Collections.Generic;
using System.Text;

namespace First.WorkingWithProeprties
{
  public  class Candidate
    {
        // _laptop
        //laptop
        private string Name;
        //Our candiate is more than 15 years
         private int Age;
        //Use underscore for fields
        private string _bvn;

        public void SetAge(int candidateAge)
        {
            if (candidateAge > 15)
            {
                Console.WriteLine("U are more than capable to vote");
                Age = candidateAge;
            }
            else
            {
                Console.WriteLine("U pass in an Invalid age ");
            }

        }
        public int GetAge()
        {
            return Age;
        }


        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }


        //public void SetBvn(string bvn)
        //{
        //    _bvn = bvn;
        //}
        //public string GetBvn()
        //{
        //    return _bvn;
        ////}
        //pROPERTY sYNTAX HAS a shortcUT T
        //  //press propgull then tab
        public string BVn
        {
            get { return  _bvn; }
            set {  _bvn = value; }
        }

        //shorter method to do things 
        // Wat u are saying here is u want t
        //private string _address  we be declared in the Compiler 
        public string  Address { get; set; }
        //Declare a proeperty of type int and the Name of the Property is "Polling Unit"
        //check the pollimh unit is less than 7

        public int PollingUnit { get; set; }

    }
}
