using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Восстания, 1", -64, -50, -10.5);
            MultiBuilding multiBuilding = new MultiBuilding("Лиговский, 15", 50, 60, 70, -5);
            building.Print();
            multiBuilding.Print();
            Console.ReadKey();

        }
    }
    public class Building
    {
        public string address { get; set; }
        double length;
        double width;
        double height;


        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Длина здания должна быть больше 0!");
                }
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ширина здания должна быть больше 0!");
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Высота здания должна быть больше 0!");
                }
            }
        }

        public Building(string address, double length, double width, double height)
        {
            this.address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", address);
            Console.WriteLine("Длина здания: {0}", length);
            Console.WriteLine("Ширина здания: {0}", width);
            Console.WriteLine("Высота здания: {0}", height);
        }

    }

    sealed class MultiBuilding : Building
    {
        int levels;
        public int Levels
        {
            get
            {
                return levels;
            }
            set
            {
                if (value > 0)
                {
                    levels = value;
                }
                else
                {
                    Console.WriteLine("Количество этажей здания должно быть больше 0!");
                }
            }
        }

        public MultiBuilding(string address, double length, double width, double height, int levels)
            : base(address, length, width, height)
        {
            Levels = levels;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей: {0}", levels);
        }
    }
}
    