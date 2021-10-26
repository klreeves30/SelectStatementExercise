using System;

namespace SelectStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 20);
            Console.WriteLine("Try to guess my favorite Number");
            var userGuess = int.Parse(Console.ReadLine());


            if (userGuess < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine("too high");
            }            
            
            else
            {
                Console.WriteLine("Youu got is you are so smart!!!");
            }

            Console.WriteLine("What is your favorite subject");
            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("Math is awesome");
                    break;
                case "English":
                    Console.WriteLine("English really is interesting");
                    break;
                case "Geometry":
                    Console.WriteLine("Geometry has lots of angles");
                    break;
                case "Algerbra":
                    Console.WriteLine("I love all the numbers that Algerbra has");
                    break;
                case "Spanish":
                    Console.WriteLine("Spanish is a beautiful language");
                    break;
                default:
                    Console.WriteLine("I don't have a favorite subject!");
                    break;
            }




        }
        

        
    }
}
