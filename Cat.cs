using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    class Motorcycle : Vehicle
    {
        //class variable
        private bool sidecar = false;

        //Get and Set for class variable
        public bool Sidecar
        {
            get { return this.sidecar; }
            set { this.sidecar = value; }
        }


        //constructor
        public Motorcycle(string theMake, string theModel, int theYear, bool HasSideCar) : base(theMake, theModel, theYear)
        {
            this.sidecar = HasSideCar;
        }

        public override string ToString()
        {
            string message = "";
            message = message + "Make:" + this.Make + "\n";
            message = message + "Model: " + this.Model + "\n";
            message = message + "Year: " + this.Year + "\n";
            if (Sidecar == true)
            {
                message = message + "With a sidecar" + "\n";
            }
            else
            {
                message = message + "Without a sidecar" + "\n";
            }
                return message;
        }








    }
}