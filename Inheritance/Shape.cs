namespace Inheritance
{
    public class Shape
    {
        // Fields
        private int sides;

        // Properties
        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }

        // Constructor 
        public Shape()
        {
            // Default
        }

        public Shape(int sides)
        {
            this.sides = sides;
        }

        // Methods
    }
}