using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    public delegate void RectDelegate(double width, double height);
    class MultiCastDelegate
    {
        public void GetArea(double width,double height)
        {
            Console.WriteLine("Area of the Rectangle:"+width*height);
        }
        public void GetPerimeter(double width,double height)
        {
            Console.WriteLine("Perimeter of Rectangle:"+2*(width+height));
        }
        static void Main(string[] args)
        {
            MultiCastDelegate n = new MultiCastDelegate();
            RectDelegate obj = n.GetArea;
            obj += n.GetPerimeter;
            obj.Invoke(12.34, 56.78);
            obj.Invoke(12, 25);
            obj.Invoke(1, 2);

        }
    }
}
