using System;

namespace OnBoardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            Console.WriteLine("Hello! Welcome to the account onboarding app!");

            user.FirstName = AskQuestion("What is your first name?");
            user.LastName = AskQuestion($"Thanks, {user.FirstName}!  What is your last name?");
            Console.WriteLine($"Great! Thanks, {user.FullName}!");

            user.IsAccountOwner = AskBoolQuestion("Are you the account owner?");
            Console.WriteLine("OK that's good to know!");
            user.PinNumber = AskIntQuestion("What is the 4 digit numeric Pin Number for the Account?", 4);
            Console.WriteLine($"Awesome! Thanks for using the onboarding application, {user.FullName}! Your information has been stored!\r\n");

            Console.WriteLine($"Name:{user.FullName}");
            Console.WriteLine($"Account Owner:{user.IsAccountOwner}");
            Console.WriteLine($"Pin Number:{ user.PinNumber}");
            Console.ReadLine();
        }

        /// <summary>
        /// Returns a question from the given string parameter
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        /// <summary>
        /// Asks a question that will result in a true or false answer
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static bool AskBoolQuestion(string question)
        {
            while (true)
            {
                var response = AskQuestion(question + " yes/no");
                if (response.ToLower().Contains("yes"))
                {
                    return true;
                }

                if (response.ToLower().Contains("no"))
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Asks a question that will result in an integer answer
        /// </summary>
        /// <param name="question"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int AskIntQuestion(string question, int length = 0)
        {
            while (true)
            {
                var response = AskQuestion(question);
                if (length > 0 && length != response.Length)
                {
                    Console.WriteLine("Invalid entry - response should be a 4 digit value");
                    continue;
                }

                if (int.TryParse(response, out var value))
                {
                    return value;
                }
                Console.WriteLine("Invalid entry - response should be a numeric value");
            }
        }
    }
}
