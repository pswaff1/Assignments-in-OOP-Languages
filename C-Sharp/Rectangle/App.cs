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

using System;
using System.Linq;

namespace RectangleOverlap {
    class App {
        static void Main(String[] args) {
            // Create two instances of the Rectangle class
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle();

            // The coordinates of the rectangles
            int[] top_left_coordinate = new int[2];
            top_left_coordinate[0] = 0;
            top_left_coordinate[1] = 0;

            int[] bottom_right_coordinate = new int[2];
            bottom_right_coordinate[0] = 0;
            bottom_right_coordinate[1] = 0;

            try {

                String buff;
                int i;

                Console.WriteLine("Rectangle 1");

                // Top-left coordinates of rectangle 1
                Console.Write("Enter the top-left coordinates: ");
                buff = Console.ReadLine();
                i = 0;
                while (buff[i] != ' ') {
                    if (buff[i] < '0' || buff[i] > '9') throw new FormatException();
                    top_left_coordinate[0] = top_left_coordinate[0] * 10 + buff[i++] - '0';
                }
                i++;
                while (i < buff.Length) {   
                    if (buff[i] < '0' || buff[i] > '9') throw new FormatException();                 
                    top_left_coordinate[1] = top_left_coordinate[1] * 10 + buff[i++] - '0';
                }
                if (top_left_coordinate[0] < 0 || top_left_coordinate[1] < 0) throw new FormatException();                

                // Bottom-right coordinates of rectangle 1
                Console.Write("Enter the bottom 2 coordinates: ");
                buff = Console.ReadLine();
                i = 0;
                while (buff[i] != ' ') {
                    if (buff[i] < '0' || buff[i] > '9') throw new FormatException();
                    bottom_right_coordinate[0] = bottom_right_coordinate[0] * 10 + buff[i++] - '0';
                }
                i++;
                while (i < buff.Length) {      
                    if (buff[i] < '0' || buff[i] > '9') throw new FormatException();              
                    bottom_right_coordinate[1] = bottom_right_coordinate[1] * 10 + buff[i++] - '0';
                }
                if (bottom_right_coordinate[0] < 0 || bottom_right_coordinate[1] < 0) throw new FormatException();
                
                rect1.setX(top_left_coordinate[0]);
                rect1.setY(top_left_coordinate[1]);
                rect1.setWidth(bottom_right_coordinate[0] - top_left_coordinate[0]);
                rect1.setHeight(bottom_right_coordinate[1] - top_left_coordinate[1]);

                top_left_coordinate[0] = 0;
                top_left_coordinate[1] = 0;
                bottom_right_coordinate[0] = 0;
                bottom_right_coordinate[1] = 0;

                Console.WriteLine("Rectangle 2");

                // Top-left coordinates of rectangle 2
                Console.Write("Enter the top-left coordinates: ");
                buff = Console.ReadLine();
                i = 0;
                while (buff[i] != ' ') {
                    if (buff[i] < '0' || buff[i] > '9') throw new FormatException();
                    top_left_coordinate[0] = top_left_coordinate[0] * 10 + buff[i++] - '0';
                }
                i++;
                while (i < buff.Length) {   
                    if (buff[i] < '0' || buff[i] > '9') throw new FormatException();                 
                    top_left_coordinate[1] = top_left_coordinate[1] * 10 + buff[i++] - '0';
                }
                if (top_left_coordinate[0] < 0 || top_left_coordinate[1] < 0) throw new FormatException();                

                // Bottom-right coordinates of rectangle 2
                Console.Write("Enter the bottom 2 coordinates: ");
                buff = Console.ReadLine();
                i = 0;
                while (buff[i] != ' ') {
                    if (buff[i] < '0' || buff[i] > '9') throw new FormatException();
                    bottom_right_coordinate[0] = bottom_right_coordinate[0] * 10 + buff[i++] - '0';
                }
                i++;
                while (i < buff.Length) {      
                    if (buff[i] < '0' || buff[i] > '9') throw new FormatException();              
                    bottom_right_coordinate[1] = bottom_right_coordinate[1] * 10 + buff[i++] - '0';
                }
                if (bottom_right_coordinate[0] < 0 || bottom_right_coordinate[1] < 0) throw new FormatException();

                rect2.setX(top_left_coordinate[0]);
                rect2.setY(top_left_coordinate[1]);
                rect2.setWidth(bottom_right_coordinate[0] - top_left_coordinate[0]);
                rect2.setHeight(bottom_right_coordinate[1] - top_left_coordinate[1]);

                // Checks if the rectangles overlap each other and prints the result
                Console.WriteLine("The rectangles {0}overlap in the 2D plane.\n", rect1.overlapExists(rect2) ? "" : "do not ");

            } catch (FormatException e) {
                // Display error message, exit program
                Console.WriteLine("Invalid input. Program has been terminated");
                Console.WriteLine(e.ToString());
                return;
            }

        }

    }
}