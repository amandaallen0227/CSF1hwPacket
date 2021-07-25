using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           #region FruitLoop Pt 1

            
            // Declare and Initialize array of 6 fruit names (as text)

            string[] fruits = { "Pinapple", "Strawberry", "Watermelon", "Orange", "Apple", "Rasberry" };

            // Set up a FOR loop and iterate through them
            // Display each value in the console

            foreach (string fruit in fruits)
            {

                Console.WriteLine(fruit);
            }
            //int fruitsInt = Convert.ToInt32(fruits);

            //for(int i = 0; i <= fruits.Length; i++)
            //{
            //Console.WriteLine("Here is a fruit, ", fruits);
            // }
            #endregion


            #region MadLib

            
            //Create A MAD LIB
            //Ask the user for various peices of information to then output a story from their answers.

            Console.WriteLine("Hello there! Please enter in some information below that will then be put into a story.");
            Console.WriteLine();
            Console.WriteLine("Write your role models' name here: " );
            string rmodelName = Console.ReadLine();
            Console.WriteLine("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter 3 Ajectives: ");
            Console.WriteLine();
            Console.WriteLine("Enter one adjective: ");
            string adjOne = Console.ReadLine();
            Console.WriteLine("Enter a title name (ie: 'master'): ");
            string adjTwo = Console.ReadLine();
            Console.WriteLine("Enter one adjective: ");
            string adjThree = Console.ReadLine();
            Console.WriteLine("Enter one verb: ");
            string verbOne = Console.ReadLine();
            Console.WriteLine("Enter 3 Nouns: ");
            Console.WriteLine("Noun One: ");
            string nounOne = Console.ReadLine();
            Console.WriteLine("Noun Two: ");
            string nounTwo = Console.ReadLine();
            Console.WriteLine("Noun Three: ");
            string nounThree = Console.ReadLine();
            Console.WriteLine("Enter a classmates name: ");
            string classmateName = Console.ReadLine();
            Console.WriteLine("Enter 2 Adverbs: ");
            Console.WriteLine();
            Console.WriteLine("Adverb One: ");
            string adverbOne = Console.ReadLine();
            Console.WriteLine("Adverb Two: ");
            string adverbtwo = Console.ReadLine();
            Console.WriteLine("Enter another Adjective: ");
            string adjFour = Console.ReadLine();
            Console.WriteLine("Enter an instructors name: ");
            string instructorName = Console.ReadLine();
            Console.WriteLine("Enter a Verb: ");
            string VerbTwo = Console.ReadLine();
            Console.WriteLine("Enter a Verb: ");
            string verbThree = Console.ReadLine();
            Console.WriteLine("Thank you! Here is your MadLib: My name is " + rmodelName + ". I've known you for " + userNumber + " days! I am so " + adjOne + " that I have met you! After only 2 weeks of school you are already a " + adjTwo + "! Don't worry I too am a " + adjThree + "! Some advice from me? Don't forget to " + adverbOne + " your " + nounOne + ". Make sure you always have your " + nounTwo + " with you when you get ready to code. If you ever have a " + nounThree + " in your application be sure you call or text " + classmateName + ". This time we have together is so " + adverbOne + " we want to make the " + adverbtwo + " of it! Don't forget, on the hard days that you are just as " + adjFour + " as " +instructorName+ ". My final word of advice: Make sure you "  +VerbTwo+ " with your code at least once a day! I cannot wait to " + verbThree+ " your code one day!"   );
            Console.WriteLine("Have a great day! From your greatest inspiration, " + rmodelName );



            //Grab user answers 

            //out put users answers
            //put user answers into a story 


            #endregion
        }// END MAIN

    } // END CLASS

} // END NAMESPACE
