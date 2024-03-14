using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Animal
    {
        protected double weight;
        protected string name;

        public Animal(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("Tên: {0}", name);
            Console.WriteLine("Cân nặng: {0:F2} kg", weight);
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }

    public class Lion : Animal
    {
        public Lion(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            base.Show();
        }
    }

    public class Tiger : Animal
    {
        public Tiger(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            base.Show();
        }
    }
}