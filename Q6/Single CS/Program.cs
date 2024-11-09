using System;

namespace CylinderApp
{
    public class Shape
    {
        protected float radius, height;

        public void SetDimensions(float r, float h)
        {
            radius = r;
            height = h;
        }
    }

    public class Cylinder : Shape
    {
        public float GetSurfaceArea()
        {
            return 2 * (float)Math.PI * radius * (radius + height);
        }
    }

    public class Program
    {
        static void Main()
        {
            Cylinder data = new Cylinder();
            data.SetDimensions(7, 10);
            Console.WriteLine("The Surface Area of the Cylinder is {0}", data.GetSurfaceArea());
            Console.ReadKey();
        }
    }
}
