using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunRecommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome user, what are you in the mood for?");
            Console.WriteLine("Here are your options:\n 1) Action \n 2) Chill Times \n 3) Danger \n 4) Good Food");
            Byte activity = Convert.ToByte(Console.ReadLine());
            

            string mood = "0";
            if (activity == 1)
                mood = "action";
            else if (activity == 2)
                mood = "chilling";
            else if (activity == 3)
                mood = "danger";
            else if (activity == 4)
                mood = "good food";
            else
                mood = "0";
                

            string actAnswer = "0";

            if (activity == 1)
                actAnswer = "Stock Car Racing";
            else if (activity == 2)
                actAnswer = "Hiking";
            else if (activity == 3)
                actAnswer = "Skydiving";
            else if (activity == 4)
                actAnswer = "to Taco Bell";
            else
                actAnswer = "0";
                

            Console.WriteLine("How many people are you bringing with you?");
            Byte people = Convert.ToByte(Console.ReadLine());
            

            string vehicle = "0";

            if (people == 0)
               vehicle = "sneakers";
            else if (people >=1 && people <=4)
               vehicle = "a sedan";
            else if (people >= 5 && people <= 10)
                vehicle = "a Volkswagen bus";
            else if (people > 10)
                vehicle = "an airplane";
            else
                vehicle = "0";
                
                

            if (vehicle == "0") 
                Console.WriteLine("Your input for the number of people was not understood. \nGoodbye");
            else if(actAnswer == "0")
                Console.WriteLine("Your input for the your mood was not understood. \nGoodbye");
            else if (vehicle == "0" && actAnswer == "0")
                Console.WriteLine("Neither of your inputs were understood. \nGoodbye");
            else
                Console.WriteLine("Okay if you're in the mood for {0}, then you should go {1} and travel in {2}\nGoodBye", mood, actAnswer, vehicle);
                

        }
    }
}
