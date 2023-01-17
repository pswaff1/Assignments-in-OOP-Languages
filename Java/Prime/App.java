/* 
 * App.java
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

package Prime;

import java.util.InputMismatchException;
import java.util.Scanner;

public class App {
    public static void main(String[] args) {

        // Prompt the user for a non-negative integer
        System.out.printf("Enter a non-negative Integer: ");
        
        try(Scanner in = new Scanner(System.in)) { 

            // Read the input from the user
            int s = in.nextInt();

            // If input is a negative number, throw exception
            if (s < 0) throw new InputMismatchException();

            // Display a message to indicate that the program is thinking
            System.out.printf("Thinking (may take awhile)... ");

            // Create an instance of the IsPrime Class
            IsPrime prime = new IsPrime();
            
            // Use the IsPrime class to check for primality
            // and display the result
            System.out.printf("The number %d is %s.\n", s, prime.calculateIsPrime(s)? "prime" : "composite (not prime)");

        } catch (InputMismatchException e) {

            // If an InputMismatchException is caught, display
            // an error message and exit the program
            System.out.println("Invalid input. Program exited");
            return;

        }

    }    
}
