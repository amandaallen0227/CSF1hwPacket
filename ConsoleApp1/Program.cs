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
        }// END MAIN

    } // END CLASS

} // END NAMESPACE
