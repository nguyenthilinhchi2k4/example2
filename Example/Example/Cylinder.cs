using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Cylinder
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public void Process()
        {
            double baseArea = Math.PI * radius * radius;
            double lateralArea = 2 * Math.PI * radius * height;
            double totalArea = 2 * Math.PI * radius * (height + radius);
            double volume = Math.PI * radius * radius * height;

            Console.WriteLine("Diện tích đáy: {0:F2}", baseArea);
            Console.WriteLine("Diện tích xung quanh: {0:F2}", lateralArea);
            Console.WriteLine("Diện tích toàn phần: {0:F2}", totalArea);
            Console.WriteLine("Thể tích: {0:F2}", volume);
        }
    }
}