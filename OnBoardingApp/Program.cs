using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            
            Console.WriteLine($"Great! Thanks, {user.FullName}");

            

            Console.ReadLine();


        }
        
        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine().ToString();
        }
    }
}
