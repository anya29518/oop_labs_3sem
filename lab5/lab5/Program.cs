using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{

    interface IWrite
    {
        void Sum();
    }


    abstract class Product
    {
        public double cost;
        public double weight;
        static int count = 0;

        public Product()
        {
            count++;
        }



        virtual public void GetInfo()
        {
            Console.WriteLine("Стоимость: " + cost + " Вес: " + weight);
        }
        

    }

    abstract class Tech : Product, IWrite
    {
        public string model; 
        static int count = 0;

        public Tech()
        {
            count++;
        }
        void IWrite.Sum()
        {
            Console.WriteLine("Всего техники: " + count);
        }
    }

    class Printer : Tech
    {
        public string type;
        public Printer(double cost, double weight, string model, string type)
        {
            this.cost = cost;
            this.weight = weight;
            this.model = model;
            this.type = type;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Принтер: " + "\nСтоимость:" + cost + " Вес:" + weight + " Производитель:" + model + " Тип: " + type);
        }
        public override string ToString()
        {
            return base.ToString() + " " + cost.ToString() + " " + weight.ToString() + " " + model.ToString() + " " + type.ToString();
        }
    }

    class Scaner : Tech
    {
        public string type;

        public Scaner(double cost, double weight, string model, string type)
        {
            this.cost = cost;
            this.weight = weight;
            this.model = model;
            this.type = type;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Сканер: " + "\nСтоимость:" + cost + " Вес:" + weight + "; Производитель:" + model + "; Тип:" + type);
        }
        public override string ToString()
        {
            return base.ToString() + " " + cost.ToString() + " " + weight.ToString() + " " + model.ToString() + " " + type.ToString();
        }
    }

    class Computer : Tech
    {
        public string type;

        public Computer(double cost, double weight, string model, string type)
        {
            this.cost = cost;
            this.weight = weight;
            this.model = model;
            this.type = type;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Компьютер:" + "\nСтоимость:" + cost + " Вес:" + weight + " Производитель:" + model + " Тип:" + type);
        }
        public override string ToString()
        {
            return base.ToString() + " " + cost.ToString() + " " + weight.ToString() + " " + model.ToString() + " " + type.ToString();
        }
    }

    class Tablet : Tech
    {
        public string color;
        public Tablet(double cost, double weight, string model, string color)
        {
            this.cost = cost;
            this.weight = weight;
            this.model = model;
            this.color = color;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Планшет:" + "\nСтоимость:" + cost + " Вес:" + weight + " Производитель:" + model + " Цвет:" + color);
        }
        public override string ToString()
        {
            return base.ToString() + " " + cost.ToString() + " " + weight.ToString() + " " + model.ToString() + " " + color.ToString();
        }
    }

    sealed class Print
    {
        public static void iAmPrinting(List<Tech> someobj)
        {
            foreach (var i in someobj)
                Console.WriteLine(i.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Printer myPrinter = new Printer(80.75, 2.2, "Canon", "цветной");
            Scaner myScaner = new Scaner(68.54, 2.5, "Samsung", "встроенный");
            Computer myComputer = new Computer(125.71, 1.7, "LG", "компьютер");
            Computer nextComputer = new Computer(70.3, 2, "ASUS", "ноутбук");
            Tablet myTablet = new Tablet(40.21, 500, "Lenovo", "черный");

            Tech tech = myPrinter as Tech;
            if (tech != null)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("Error");
            }
            myPrinter.GetInfo();
            myScaner.GetInfo();
            myComputer.GetInfo();
            nextComputer.GetInfo();
            myTablet.GetInfo();


            IWrite iwrite = tech;
            iwrite.Sum();
            List<Tech> techs = new List<Tech>();
            techs.Add(myPrinter);
            techs.Add(myScaner);
            techs.Add(myComputer);
            techs.Add(nextComputer);
            techs.Add(myTablet);
            Print.iAmPrinting(techs);
            Console.ReadKey();
        }
    }
}
