using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace lab6
{
    interface IWrite
    {
        void Sum();
    }

    class TechException:Exception
    {
        public TechException (string message)
            : base(message)
        { }
    }

    class ControllerException:Exception
    {
        public ControllerException (string message)
            :base (message)
        { }
    }

    class vException:Exception
    {
        public vException (string message)
            :base (message)
        { }
    }

    abstract class Product
    {
        public double cost;
        public double weight;
        virtual public void GetInfo()
        {
            Console.WriteLine("Стоимость: " + cost + " Вес: " + weight);
        }
       
    }

    abstract partial class Tech : Product, IWrite
    {
        public string model;
        public int worktime;
        public int release;
        public static int count = 0;

        //public Tech()    эта часть класса в другом файле
        //{
        //    count++;
        //}
        //void IWrite.Sum()
        //{
        //    Console.WriteLine("Всего техники: " + count);
        //}
    }
    class Laboratory
    {
        int count = 0;
        
        public List<Tech> list = new List<Tech>();
        
        public void Add(Tech ob)
        {
            list.Add(ob);
            count++;
        }
        public void Delete(Tech ob)
        {
            if(count==0)
            {
                throw new NullReferenceException(" Цена не может быть равна 0!");
            }
            list.Remove(ob);
            count--;
        }
        public  void Printing()
        {
            foreach (var i in list)
                Console.WriteLine(i.ToString());
        }
    }
    class Printer : Tech
    {
        public string type;
        public static int amount = 0;
        public Printer(double cost, double weight, string model, string type, int release)
        {
            this.cost = cost;
            this.weight = weight;
            this.model = model;
            this.type = type;
            worktime = 5;
            this.release = release;
            if(release>2020)
            {
                throw new vException("Неверный год выпуска!");
            }
            amount++;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Принтер: " + "\nСтоимость:" + cost + " Вес:" + weight + " Производитель:" + model + " Тип: " + type +"Год выпуска "+release);
            Console.WriteLine("Номер принтера: " + amount);
        }
        public override string ToString()
        {
            return base.ToString() + " " + cost.ToString() + " " + weight.ToString() + " " + model.ToString() + " " + type.ToString();
        }
    }

    class Scaner : Tech
    {
        public string type;
        public static int amount = 0;
        public Scaner(double cost, double weight, string model, string type, int release)
        {
            this.cost = cost;
            this.weight = weight;
            this.model = model;
            this.type = type;
            worktime = 3;
            this.release = release;
            if(release>2020)
            {
                throw new vException("Неверный год выпуска!");
            }
            amount++;
        }
        
        public override void GetInfo()
        {
            Console.WriteLine("Сканер: " + "\nСтоимость:" + cost + " Вес:" + weight + "; Производитель:" + model + "; Тип:" + type+ "Год выпуска"+release);
            Console.WriteLine("Номер сканера: " + amount);
        }
        public override string ToString()
        {
            return base.ToString() + " " + cost.ToString() + " " + weight.ToString() + " " + model.ToString() + " " + type.ToString();
        }
    }

    class Computer : Tech
    {
        public string type;
        public static int amount;
        public Computer(double cost, double weight, string model, string type, int release)
        {   
            this.cost = cost;
            this.weight = weight;
            this.model = model;
            this.type = type;
            worktime = 0;
            Debug.Assert(worktime != 0,"Компьютер еще не использовался!");
            this.release = release;
            if (release > 2020)
            {
                throw new vException("Неверный год выпуска!");
            }
            amount++;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Компьютер:" + "\nСтоимость:" + cost + " Вес:" + weight + " Производитель:" + model + " Тип:" + type+"Год выпуска "+release);
            Console.WriteLine("Номер компьютера: " + amount);
        }
        public override string ToString()
        {
            return base.ToString() + " " + cost.ToString() + " " + weight.ToString() + " " + model.ToString() + " " + type.ToString();
        }
    }

    class Tablet : Tech
    {
        public static int amount=0;
        public string color;
        public Tablet(double cost, double weight, string model, string color, int release)
        {
            this.cost = cost;
            this.weight = weight;
            this.model = model;
            this.color = color;
            worktime = 4;
            this.release = release;
            if (release > 2020)
            {
                throw new vException("Неверный год выпуска!");
            }
            amount++;
            if (worktime > 10)
            {
                throw new TechException("Техника используется слишком долго!");
            }
            if (amount > 20)
            {
                throw new IndexOutOfRangeException("Слишком много планшетов!");
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine("Планшет:" + "\nСтоимость:" + cost + " Вес:" + weight + " Производитель:" + model + " Цвет:" + color + "Год выпуска" + release);
            Console.WriteLine("Номер планшета: " + amount);
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

    struct T
    {
        public string NameOfTech;
        public int cost;
        public T(string name,int cost)
        {
            NameOfTech = name;
            this.cost = cost;
        }

    }

    enum Types
    {
        Computer,
        Printer,
        Tablet,
        Scaner
    }
    
     class Controller:Laboratory
    {
        public void NumberOfEachType()
        {
            Console.WriteLine("Количество каждого вида техники ");
            Console.WriteLine("Количество принтеров: "+Printer.amount);
            Console.WriteLine("Количество сканеров:"+Scaner.amount);
            Console.WriteLine("Количество компьютеров: "+Computer.amount);
            Console.WriteLine("Количество планшетов: "+Tablet.amount);

        }
        public void SortByCost()
        {

            Console.WriteLine("");
            for (int i = 1; i < Tech.count; ++i)
            {
                for (int j = 0; j < Tech.count - i; j++)
                {
                    if (list[j].cost < list[j + 1].cost)
                    {
                        var p = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = p;

                    }
                }
            }
            foreach(Tech t in list)
            {
                Console.WriteLine(t);
            }
           
        }

        public void OldTechCheck(Tech t)
        {
            Console.WriteLine(" ");
            //foreach (Tech t in list)
            //{
            if ((t.release + t.worktime) < 2010)
            {
                throw new ControllerException("");
            }
            else if ((t.release + t.worktime) < 2020)
                {
                    Console.WriteLine("Срок работы истек");
                }
                else
                {
                    Console.WriteLine("Технику можно использовать");
                }

            //}
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Printer myPrinter = new Printer(80.75, 2.2, "Canon", "цветной", 2000);
                myPrinter.GetInfo();
                Scaner myScaner = new Scaner(68.54, 2.5, "Samsung", "встроенный", 2018);
                myScaner.GetInfo();
                Computer myComputer = new Computer(125.71, 1.7, "LG", "компьютер", 1998);
                myComputer.GetInfo();
                Computer nextComputer = new Computer(70.3, 2, "ASUS", "ноутбук", 2009);
                nextComputer.GetInfo();
                Tablet myTablet = new Tablet(40.21, 500, "Lenovo", "черный", 2042);
                myTablet.GetInfo();
                Console.WriteLine("______________________________");

                Tech tech = myPrinter as Tech;
                if (tech != null)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("Error");
                }
                IWrite iwrite = tech;
                iwrite.Sum();
                Console.WriteLine("______________________________");
                Controller c = new Controller();
                c.Add(myPrinter);
                c.Add(myScaner);
                c.Add(myComputer);
                c.Add(nextComputer);
                c.Add(myTablet);
                c.Printing();
                Console.WriteLine("______________________________");
                c.NumberOfEachType();
                Console.WriteLine("Проверка срока службы планшета");
                c.OldTechCheck(myTablet);
                Console.WriteLine("Сортировка по цене");
                c.SortByCost();
            }
            catch(ControllerException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\nМестонахождение:{ex.StackTrace}");
            }
            catch (TechException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\nМестонахождение:{ex.StackTrace}");
            }
            catch (vException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\nМестонахождение:{ex.StackTrace}");
                throw;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\nМестонахождение:{ex.StackTrace}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\nМестонахождение:{ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.ReadKey();
        }
    }
}
