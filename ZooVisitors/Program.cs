using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ///prompt & input
            Console.WriteLine("Enter the animal's hunger level (1-10): ");
            Console.Write(">");
            int hungerLevel = int.Parse(Console.ReadLine());
            
            ///if-else
            if (hungerLevel >= 8)
            {
                Console.WriteLine("Lion: Roar! I need a big meanl!");
            }
            else if (hungerLevel >=5)
            {
                Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
            }
            else if (hungerLevel <5)
            {
                Console.WriteLine("Tortoise: Slow and steady—I'll have some lettuce.");
            }

            ///ternary operator
            string msg = hungerLevel >= 8 ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";
            Console.WriteLine(msg);
5
            ///prompt & input
            Console.WriteLine(@"Enter the current day of the week: 
1 Monday
2 Tuesday
3 Wednesday
4 Thursday
5 Friday
6 Saturday
7 Sunday");
            Console.Write(">");
            string day = Console.ReadLine();
            
            ///switch
            switch(day) 
            {
            case "1": ///monday
                Console.WriteLine("Monkey Monday is today!");
                break;
            case "2": ///tuesday
                Console.WriteLine("Join us for Tortoise Tuesday!");
                break;
            case "3": ///wednesdat
                Console.WriteLine("Wednesdays are for Stingrays!");
                break;
            case "4": ///thursday
                Console.WriteLine("Seniors get 10% off admission on Thursday!");
                break;
            case "5": ///friday
                Console.WriteLine("Thank god it's Friday");
                break;
            case "6": ///saturday
                Console.WriteLine("Senior Saturday!");
                break;
            case "7": ///sunday
                Console.WriteLine("Children under 12 get free tickets on Sundays!");
                break;
            }
        }
    }
}