namespace Vehicles_and_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Toyota", "Prius", 2004, 4);
            Console.WriteLine(car1.ToString());

            Motorcycle motor1 = new Motorcycle("Bradford", "annilator", 2025, false);
            Console.WriteLine(motor1.ToString());

        }
    }
}
