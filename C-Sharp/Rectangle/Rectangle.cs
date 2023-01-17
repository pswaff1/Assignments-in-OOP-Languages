/* 
 * Rectangle.java
 *
 * This class, named "Rectangle", represents a rectangle object in a 2D plane. 
 * It has four private fields: x, y, width, and height, which represent the 
 * coordinates of the top-left corner of the rectangle, and the width and height 
 * of the rectangle.
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

namespace RectangleOverlap {
    class Rectangle {
        private int x;
        private int y;
        private int width;
        private int height;

        public Rectangle() {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
        }

        // Standard OOP getters and setters
        public void setX (int x) {
            this.x = x;
        }

        public int getX () {
            return this.x;
        }

        public void setY (int y) {
            this.y = y;
        }

        public int getY () {
            return this.y;
        }

        public void setWidth (int width) {
            this.width = width;
        }

        public int getWidth () {
            return this.width;
        }

        public void setHeight (int height) {
            this.height = height;
        }

        public int getHeight () {
            return this.height;
        }

        // Checks if this rectangle overlaps with another rectangle
        public bool overlapExists (Rectangle rect) {
            
            if (checkOverlap(this.getX(), rect.getX(), this.getWidth(), rect.getWidth()) && 
                checkOverlap(this.getY(), rect.getY(), this.getHeight(), rect.getHeight())) 
                return true;

            return false;
        }

        private bool checkOverlap (int thisPOS, int thatPOS, int thisSPAN, int thatSPAN) {
            if (thatPOS <= (thisPOS + thisSPAN) && 
                (thatPOS + thatSPAN) >= thisPOS)
                return true;
            return false;
        }
    }
}