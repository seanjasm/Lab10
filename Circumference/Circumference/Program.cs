using System;
using System.Collections.Generic;

namespace Circumference
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            List<Circle> circleList = new List<Circle>();
            bool repeat = true;
            string user = Validator.GetUserInput("Enter your name: ");
            Validator.Display($"Hello {user}! Let's get started.");
            while (repeat)
            {
                try
                {
                    Circle circle = new Circle(Validator.GetUserInputAsDouble($"Enter the radius for circle {index}: "));
                    Validator.Display(circle.CalculateFormattedCircumference());
                    Validator.Display(circle.CalculateFormattedArea());
                    circleList.Add(circle);
                }
                catch(Exception e)
                {
                    Validator.Display(e.Message);
                }
                index++;
                repeat = Validator.UserConfirmationPrompt("Repeat(Y/N)? ");
                Console.Clear();
            }
            Validator.Display("Here's what you've done on this session:\n\n");
            for(index = 0; index < circleList.Count; index++)
            {
                Validator.Display(string.Format("Circle {0}: Radius: {1}", index+1, 
                    circleList[index].GetRadius()));
                Validator.Display("\t" + circleList[index].CalculateFormattedCircumference());
                Validator.Display("\t" + circleList[index].CalculateFormattedArea());
            }
            Validator.Display($"\nGoodbye, {user}!\n\n");
        }
    }
}
