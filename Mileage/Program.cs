using System;

namespace Mileage
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("How many miles have you driven?: ");
            // Get input from the user and save it to a variable.

            string mileage = Console.ReadLine();
            float miles = float.Parse(mileage);


            Console.Write("How many gallons of gas have you consumed? ");
            // Get input from the user and save it to a second variable.

            string gas = Console.ReadLine();
            float gallons = float.Parse(gas);

            // Output - Your miles per gallon is (computed value)

            float mpg = miles / gallons;

            Console.WriteLine("Your miles per gallon is: " + mpg);
            Console.ReadLine();

            
        }
    }
}
