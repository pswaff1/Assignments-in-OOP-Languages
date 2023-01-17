/* 
 * App.java
 *
 * This class, named "App", contains a main method which creates two instances of the 
 * "Rectangle" class, prompts the user for input to specify the top-left and bottom-right 
 * coordinates of the rectangles and assigns the values to the instances. Then it calls a method 
 * on the first rectangle instance to check if it overlaps with the second rectangle and prints the 
 * result to the console. The input is read by a scanner and is handled by a try-catch block 
 * which catches an InputMismatchException, displays an error message and exits the program 
 * if the input is invalid.
 * 
 * NCU.edu
 * School of Business & Technology Management
 * TIM-6110: Programming Languages & Algorithms
 * 
 * Author: Patrick Swafford
 * Date: 22 January 2023
 * 
*/

package Rectangle;

import java.util.Scanner;
import java.util.InputMismatchException;


public class App {
    public static void main(String[] args) {

        // Creates two instances of the Rectangle Class
        Rectangle rect1 = new Rectangle();
        Rectangle rect2 = new Rectangle();

        // The coordinates of the rectangles
        int x1,y1;
        int x2,y2;
     
        try (Scanner in = new Scanner(System.in)) {

            // Input the top-left and bottom-right coordinates of Rectangle 1
            System.out.println("Rectangle 1");
            System.out.printf("Enter the top left X, Y coordinates: ");
            x1 = in.nextInt();
            y1 = in.nextInt();
            // Checks if inputs are valid. This program assumes non-negative coordinates
            // as would be seen in an instance of Canvas
            if (x1 < 0 || y1 < 0) throw new InputMismatchException();

            System.out.printf("Enter the bottom right x, y coordinates: ");
            x2 = in.nextInt();
            y2 = in.nextInt();
            // Checks if inputs are valid
            if (x2 < x1 || y2 < y1) throw new InputMismatchException();            

            // Set the coordinates of rectangle 1
            rect1.setX(x1);
            rect1.setY(y1);
            rect1.setWidth(x2 - x1);
            rect1.setHeight(y2 - y1);


            // Input coordinates for rectangle 2
            System.out.println("Rectangle 2");
            System.out.printf("Enter the top left X, Y coordinates: ");
            x1 = in.nextInt();
            y1 = in.nextInt();
            // Check if inputs are valid
            if (x1 < 0 || y1 < 0) throw new InputMismatchException();

            System.out.printf("Enter the bottom right x, y coordinates: ");
            x2 = in.nextInt();
            y2 = in.nextInt();
            if (x2 < x1 || y2 < y1) throw new InputMismatchException();

            // Set the coordinates of Rectangle 2
            rect2.setX(x1);
            rect2.setY(y1);
            rect2.setWidth(x2 - x1);
            rect2.setHeight(y2 - y1);
 
            // Checks if the rectangles overlap each other and prints the result
            System.out.printf("The rectangles %soverlap in the 2D plane.\n", rect1.overlapExists(rect2) ? "" : "do not ");

        }catch (InputMismatchException e) {

            // If an InputMismatchException is caught, display
            // an error message and exit the program
            System.out.println("Invalid input. Program exited");
            return;

        }
    }
}
