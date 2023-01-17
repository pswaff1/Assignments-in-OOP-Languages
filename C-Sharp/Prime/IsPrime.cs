/* 
 * IsPrime.cs
 *
 * The IsPrime class contains a single method, "calculateIsPrime(int n)", 
 * which takes an integer input and returns a boolean value indicating whether 
 * or not the input is a prime number. The method checks if the input is less 
 * than 2 and returns false if it is. It then iterates through numbers 2 to the 
 * square root of the input and returns false if any of them are a factor of the 
 * input. If none of these conditions are met, it returns true, indicating that 
 * the input is a prime number.
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

namespace Primality {
    class IsPrime {
        public bool calculatePrimality(int n) {
            
            // Numbers 0 and 1 by definition are not prime
            if (n < 2) return false;

            // If any number between 2 and the square root of the input n
            // divides evenly into n, the input is composite and the
            // method returns false accordingly
            for (int i = 2; i <= Math.Pow(n, 0.5); i++) {
                if (n % i == 0) return false;
            }

            // The input has been found to be prime, thus return true
            return true;
        }
    }
}