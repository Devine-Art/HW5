using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    public class Vehicle
    {
        //class variables
        private string make = "N/A";
        private string model = "N/A";
        private int year = 0;

        //Gets and Sets

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        //Constructor
        public Vehicle(string theMake, string theModel, int theYear)
        {
            this.Make = theMake;
            this.Model = theModel;
            this.Year = theYear;
        }

        public override string ToString()
        {
            string message = "";
            message = message + "Make:" + this.Make + "\n";
            message = message + "Model: " + this.Model + "\n";
            message = message + "Year: " + this.Year + "\n";
            return message;
        }





    }
}
