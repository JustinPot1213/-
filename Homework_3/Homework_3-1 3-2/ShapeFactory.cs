using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public class ShapeFactory
    {
        private readonly int createdNum;
        private Shape[] products;
        public Double Sum { set; get; }

        public ShapeFactory(int createNum)
        {
            if (createNum > 0)
            {
                this.createdNum = createNum;
                products = new Shape[createNum];
            }
            else Console.WriteLine("生产个数不能非正");
        }

        public void CreateShape()
        {
            Random rnd = new Random();
            int randomNum;
            string type;
            for(int i = 0; i < createdNum; i++)
            {
                randomNum = rnd.Next(0, 3);
                type=Shape.TypeOfShape[randomNum];
                bool flag = false;
                switch (type)
                {
                    case "Square":
                        while (!flag)
                        {
                            this.products[i] =
                                new Square(rnd.Next(1, 100));
                            flag = products[i].Legality;
                        }
                        break;
                    case "Rectangle":
                        while (!flag)
                        {
                            this.products[i] =
                            new Rectangle(rnd.Next(1, 100), rnd.Next(1, 100));
                            flag = products[i].Legality;
                        }
                        break;
                    case "Triangle":
                        while (!flag)
                        {
                            this.products[i] =
                            new Triangle(rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                            flag = products[i].Legality;
                        }
                        break;
                }
            }
        }

        public void GetAreaSum()
        { 
            for(int i = 0; i < createdNum; i++)
            {
                //products[i].ShowArea();
                Sum += products[i].Area;
            }
        }
    }

    class Prpgram
    {
        public static void Main(string[] args)
        {
            ShapeFactory sf = new ShapeFactory(10);
            sf.CreateShape();
            sf.GetAreaSum();
            Console.WriteLine($"总面积为{sf.Sum}");
        }
    }
}
