using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{

    public abstract class Shape {

        static public string[] TypeOfShape = { "Square", "Rectangle", "Triangle" };

        private double area;
        public bool Legality { set; get; }
        public double Area
        {
            get => area;
            set => area = value;
        }
        public abstract void ShowArea();
    }

    public class Rectangle : Shape
    {
        private readonly int width,height;

        public Rectangle(int width,int length)
        {
            if (width > 0 && length > 0 && length >= width)
            {
                this.width = width;
                this.height = length;
                this.Area = width * length;
                this.Legality = true;
            }
            else
            {
                this.Legality = false;
                //Console.WriteLine("设置参数有误。");
            }
        }

        public override void ShowArea()
        {
            Console.WriteLine($"该长方形面积为{Area}");
        }

    }

    public class Square : Rectangle
    {
        public Square(int side) : base(side, side) { }

        public override void ShowArea()
        {
            Console.WriteLine($"该正方形面积为{Area}");
        }

    }

    public class Triangle : Shape
    {
        private readonly int side_1,side_2,side_3;
        public Triangle(int side_1, int side_2, int side_3)
        {
            if ((
                (side_1 + side_2) > side_3) && 
                ((side_3 + side_1) > side_2)&&
                ((side_3 + side_2) > side_1))
            {
                this.side_1 = side_1;
                this.side_2 = side_2;
                this.side_3 = side_3;
                double temp = (side_1 + side_2 + side_3) / 2;
                double temp_1 = (temp * (temp - side_1) * (temp - side_2) * (temp - side_3));
                this.Area = Math.Pow(temp_1,0.5);
                this.Legality = true;
            }
            else
            {
                this.Legality = false;
                //Console.WriteLine("设置参数有误。");
            }
        }

        public override void ShowArea()
        {
            Console.WriteLine($"该三角面积为{Area}");
        }
    }

}
