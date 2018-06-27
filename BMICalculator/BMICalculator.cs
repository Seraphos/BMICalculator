using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class BMICalculator
    {
        static void Main(string[] args)
        {
            int weightInPounds, heightInInches, bodyMassIndex;

            Console.Write("Please enter your weight in pounds: ");
            weightInPounds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your height in inches: ");
            heightInInches = Convert.ToInt32(Console.ReadLine());

            bodyMassIndex = (weightInPounds * 703) / (heightInInches * heightInInches);

            if (bodyMassIndex <= 18.5)
                Console.WriteLine("You are underweight.");
            if (bodyMassIndex >= 18.5 && bodyMassIndex <= 24.9)
                Console.WriteLine("You are normal weight.");
            if (bodyMassIndex >= 25 && bodyMassIndex <= 29.9)
                Console.WriteLine("You are overweight.");
            if (bodyMassIndex > 30)
                Console.WriteLine("You are obese!");
            Console.ReadKey();
        }
    }
}
