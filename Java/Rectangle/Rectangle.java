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

package Rectangle;

public class Rectangle {
    private int x;
    private int y;
    private int width;
    private int height;

    // Default contructor to initialize x, y, width, and height to 0
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
    public boolean overlapExists (Rectangle rect) {
        if (xOverlap(rect) && yOverlap(rect))
            return true;
        return false;
    }

    // A helper method to check for overlap on the x-axis
    private boolean xOverlap (Rectangle rect) {
        if (rect.getX() <= (this.getX() + this.getWidth()) )
            if ( (rect.getX() + rect.getWidth()) >= this.getX())
                return true;
        return false;
    }

    // A helper method to check for overlap on the y-axis
    private boolean yOverlap (Rectangle rect) {
        if (rect.getY() <= (this.getY() + this.getHeight()) )
            if ( (rect.getY() + rect.getHeight()) >= this.getY())
                return true;
        return false;
    }
}
