﻿using System;
using System.Collections.Generic;
using System.Text;

using CGALDotNet.Geometry;

namespace CGALDotNet.CSG
{
    public class RoundNode2 : Node<Point2d, double>
    {
        public RoundNode2(Node<Point2d, double> node, double radius)
        {
            AddChild(node);
            Radius = radius;
        }

        public double Radius;

        public override double Func(Point2d point)
        {
            var sdf = GetChildOrDefault(0).Func(point);

            return sdf - Radius;
        }
    }
}