using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double radius, height;

            Console.Write("Nhập bán kính: ");
            radius = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều cao: ");
            height = double.Parse(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();



            Lion lion = new Lion(150, "Leo");
            lion.Show();

            Console.WriteLine("-----");

            Tiger tiger = new Tiger(100, "Tigress");
            tiger.Show();

        }
    }
}
