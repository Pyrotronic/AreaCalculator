using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Triangle:IShape
    {
        public double FirstSide 
        {
            get
            {
                return FirstSide;
            }
            set
            {
                if (value > 0)
                {
                    FirstSide = value;
                }
            }
        }
        public double SecondSide
        {
            get
            {
                return SecondSide;
            }
            set
            {
                if (value > 0)
                {
                    SecondSide = value;
                }
            }
        }
        public double ThirdSide
        {
            get
            {
                return ThirdSide;
            }
            set
            {
                if (value > 0)
                {
                    ThirdSide = value;
                }
            }
        }
        public Triangle (double firstside, double secondside, double thirdside)
        {
            FirstSide = firstside;
            SecondSide = secondside;
            ThirdSide = thirdside;
            if (IsValid())
            {
                throw new ArgumentException("Неправильно указаны длины сторон");
            }
        }
        private bool IsValid()
        {
             return (FirstSide + SecondSide > ThirdSide) && (FirstSide + ThirdSide > SecondSide) && (SecondSide + ThirdSide > FirstSide);
        }
        public bool IsRightTriangle()
        {
            double[] sides = {FirstSide, SecondSide, ThirdSide};
            Array.Sort(sides);
            return Math.Pow(sides[2], 2) - Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2) == 0;
        }
        public double GetArea()
        {
            double s = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(s * (s - FirstSide) * (s - SecondSide) * (s - ThirdSide));
        }
    }
}
