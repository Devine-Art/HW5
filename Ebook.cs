using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    public class Car : Vehicle
    {
        //class variable
        private int doors = 0;

        //Get and Set for class variable
        public int Doors
        {
            get { return this.doors; }
            set { this.doors = value; }
        }


        //constructor
        public Car(string theMake, string theModel, int theYear, int theDoors) : base(theMake, theModel, theYear)
        {
            this.Doors = theDoors;  
        }

        public override string ToString()
        {
            string message = "";
            message = message + "Make:" + this.Make + "\n";
            message = message + "Model: " + this.Model + "\n";
            message = message + "Year: " + this.Year + "\n";
            message = message + "With" + this.Doors + "doors" + "\n";
            return message;
        }








    }
}
