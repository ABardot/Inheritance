namespace Inheritance
{
    public class Rectangle : Shape
    {
        private double area;

        public Rectangle(double area)
        {
            this.area = area;
        }

        public double Area
        {
            get { return this.area; }
            set {this.area = value; }
        }
    }
}