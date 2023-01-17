/* 
 * App.cs
 *
 * The App class is the main class of the program. It prompts
 * the user to enter a non-negative integer, and then uses the
 * IsPrime class to check if the entered number is prime or
 * not. If the user enters a negative number or a non-numeric
 * character, an InputMismatchException is thrown and the 
 * program exits
 * 
 * NCU.edu
 * School of Business & Technology Management
 * TIM-6110: Programming Languages & Algorithms
 * 
 * Author: Patrick Swafford
 * Date: 22 January 2023
 * 
*/  

using System;
using System.Linq;

namespace Primality {
    class App {
        static void Main(string[] args) {
            // Prompt user for non-negative integer
            Console.Write("Enter a non-negative integer: ");

            try {

                // Read the input from the user
                int s = int.Parse(Console.ReadLine());

                // If the input is negative, throw an exception
                if (s < 0) throw new FormatException();

                // Display a message warning this may take a while
                Console.Write("Thinking (may take a while)... ");

                //Create an instance of the IsPrime class
                IsPrime prime = new IsPrime();

                // Use the IsPrime method to check for primality
                // and output the result
                Console.WriteLine("The number {0} is {1}.", s, prime.calculatePrimality(s) ? "prime" : "composite (not prime)");

            } catch (FormatException) {
                // Display error message, exit program
                Console.WriteLine("Invalid input. Program has been terminated");
                return;
            }
        }
    }
}