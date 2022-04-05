using System;

namespace Bai2
{
    partial class Program
    {
        class Circle
        {
            public float radius { get; set; }

            public Circle(float radius)
            {
                this.radius = radius;
            }


            public Circle()
            {
            }

            public float Area()
            {
                return (float)(radius * radius * Math.PI);
            }

            public float Perimeter()
            {
                return (float)(2 * radius * Math.PI);
            }
        }

    }
}
