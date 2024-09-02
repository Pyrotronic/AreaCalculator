namespace AreaCalculator
{
    public class Circle:IShape
    {
        public double Radius { 
            get
            {
                return Radius;
            }
            set
            {
                if (value > 0) {
                    Radius = value;
                }
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Radius;
        }
    }
}
