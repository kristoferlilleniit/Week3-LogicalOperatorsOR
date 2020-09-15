using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int Age = Int32.Parse(Console.ReadLine());

            if(Age <= 20)
            {
                Console.WriteLine("You're too young.");
            }else if(Age > 60)
            {
                Console.WriteLine("You're too old.");
            }else
            {
                Console.WriteLine("How tall are you? (In meters)");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("How much do you weigh?");
                double weight = double.Parse(Console.ReadLine());
                double result = weight / ((height / 100.0) * (height / 100.0));
                //Console.WriteLine($"Your BMI is: {result}");

                if (result > 30)
                {
                    Console.WriteLine($"You're heavily overweight!");
                }
                else if (result > 25 && result <= 29.9)
                {
                    Console.WriteLine($"You're overweight!");
                }else if (result > 19 && result < 24.9)
                {
                    Console.WriteLine($"You're average weight.");
                }else
                {
                    Console.WriteLine($"You're underweight.");
                }
            }
        }
    }
}
