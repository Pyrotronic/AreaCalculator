﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Calculator
    {
            public static double CalculateArea(IShape shape)
            {
                return shape.GetArea();
            }

    }
}
