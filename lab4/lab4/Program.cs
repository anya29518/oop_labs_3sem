using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    //interface IGeneric<T>
    //{
    //    void Add(T item);
    //    void Remove(T item);
    //    void Display(Set<T> Item);

    //}

    public class Set<T> //: IGeneric<T>
    {

        public class Date
        {
            public DateTime date;
            public Date()
            {
                date = DateTime.Now;
            }
        }
        public class Owner
        {
            public int id = 5;
            public string name = "Anna Kravchenko";
            public string organization = "FIT, BSTU";

        }
        public List<T> Items = new List<T>();
        public void Remove(T item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }

        //public static void operator -(T Items; T item)
        //{
        //    if (Items.Contains(item))
        //    {
        //        Items.Remove(item);
        //    }
        //}
        public int count
        {
         get{
                return Items.Count;
            }
        }

        public static bool operator >(Set<T> set1,Set<T> set2)//Проверка на подмножество
        {
            Console.WriteLine("Проверка на подмножество\n");
            foreach (T elem in set1.Items)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
            foreach (T elem in set2.Items)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();

            int c = 0;
            foreach(T elem in set2.Items)
            {
                if (set1.Items.Contains(elem))
                {
                    c++;
                }
            }
            if (c == set2.Items.Count)
            {
                return true;
            }
            else return false;
        }
        public static bool operator <(Set<T> set1,Set<T> set2)
        {  
            return true;
        }
        public static bool operator !=(Set<T> set1, Set<T> set2)//Проверка на неравенство множеств
        {
            Console.WriteLine("Проверка на неравенство множеств\n");
            foreach (T elem in set1.Items)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
            foreach (T elem in set2.Items)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
           
            int c = 0;
            foreach (T elem in set1.Items)
            {
                if (set2.Items.Contains(elem))
                {
                    c++;
                }

            }
            if (c == set2.Items.Count && c == set1.Items.Count)
            {
                return false;
            }
            else return true;
        }
        public static bool operator ==(Set<T> set1, Set<T> set2)
        {
            //try
            //{
                foreach (T elem in set1.Items)
                {
                    Console.Write($"{elem}\t");
                }
                Console.WriteLine();
                foreach (T elem in set2.Items)
                {
                    Console.Write($"{elem}\t");
                }
                Console.WriteLine();
               
                int c = 0;
                foreach (T elem in set1.Items)
                {
                    if (set2.Items.Contains(elem))
                    {
                        c++;
                    }

                }
                if (c == set2.Items.Count && c == set1.Items.Count)
                {
                    return true;
                }
                else return false;
           // }
            //catch (Exception e)
            //{
            //   // Console.WriteLine("Error: " + e.Message);
            //    return false;
            //}
        }
        public void Add(T item)//Добавление элемента во множество
        {
            
            if (!Items.Contains(item))
            {
                Items.Add(item);
            }
        }
        public static string operator %(Set<T> set1,Set<T> set2)//Пересечение множеств
        {
            Console.WriteLine("Пересечение множеств:\n");
            foreach (T elem in set1.Items)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
            foreach (T elem in set2.Items)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
           
            Set<T> set3 = new Set<T>();
            foreach (T elem in set1.Items)
            {
                if (set2.Items.Contains(elem))
                {
                    set3.Add(elem);
                }
            }
            foreach (T elem in set3.Items)
            {
                Console.WriteLine(elem);
            }
            return null;
        }
        public void Display(Set<T> Item)
        {
            foreach (T elem in Item.Items)
            {
                Console.Write($"{elem}  ");
            }
            Console.WriteLine();
        }
        
    }
    static public class StaticOperation
    {
        static int count;
        static int sum;
        static int max = -99999;
        static int min = 99999;
        public static void Sum(Set<int> Item)//Сумма элементов
        {
            foreach (int elem in Item.Items)
            {
                sum += elem;
            }
            System.Console.WriteLine($"Сумма элементов {sum}");
            sum = 0;
        }
        public static void Difference(Set<int> Item)//Разница между максимальным и минимальным
        {

            foreach (int elem in Item.Items)
            {
                if (elem > max)
                {
                    max = elem;
                }
                if (elem < min)
                {
                    min = elem;
                }
            }
            int difference = max - min;
            Console.WriteLine($"Разница между максимальным и минимальным элементом {difference}");
        }
        public static void Count(Set<int> Item)//Подсчет количества элементов
        {
            foreach (int elem in Item.Items)
            {
                count++;
            }
            Console.WriteLine($"Количество элементов {count}");
            count = 0;
        }
        public static void K_Element(this string str, int k)//Поиск к-го элемента
        {
           
            for (int i = 0; i < str.Length; i++)
            {
                if (i == k - 1)
                {
                    Console.WriteLine(str[i]);
                    break;
                }
            }

        }
        public static void Shortest_word(this string str)//Поиск самого короткого слова
        {
            //str = str.Trim();
            string[] words = str.Split(' ');
            string word = "";
            int len = 99999;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < len)
                {
                    len = words[i].Length;
                    word = words[i];
                }

            }
            Console.WriteLine(str);
            Console.WriteLine($"Самое короткое слово в строке: {word}");
        }
        public static void Upor(this Set<int> s)//Упорядочивание множества
        {
            int el = 0;
            foreach (int elem in s.Items)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < s.Items.Count; i++)
            {
                for (int j = 0; j < s.Items.Count - 1; j++)
                {
                    if (s.Items[j] > s.Items[j + 1])
                    {
                        el = s.Items[j];
                        s.Items[j] = s.Items[j + 1];
                        s.Items[j + 1] = el;

                    }
                }
            }
            
            foreach (int elem in s.Items)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Set<int>.Date today = new Set<int>.Date();
            Console.WriteLine($"Сегодня {today.date}");
            Set<int>.Owner inf = new Set<int>.Owner();
            Console.WriteLine($"Информация о создателе:\n ID: {inf.id}\n NAME: {inf.name}\n ORGANISATION: {inf.organization}");
            Set<int> obj1 = new Set<int>();
            obj1.Add(-5);
            obj1.Add(12);
            obj1.Add(2);
            obj1.Add(-37);
            obj1.Add(0);
            obj1.Add(-1);
            obj1.Display(obj1);
            StaticOperation.Count(obj1);
            StaticOperation.Sum(obj1);
            StaticOperation.Difference(obj1);
            StaticOperation.Upor(obj1);
            Set<int> obj2 = new Set<int>();
            obj2.Add(1);
            obj2.Add(2);
            obj2.Add(3);
            obj2.Add(7);
            obj2.Display(obj2);
            StaticOperation.Count(obj2);
            StaticOperation.Sum(obj2);
            StaticOperation.Difference(obj2);
            string str = "1234567890";
            StaticOperation.K_Element(str, 10);
            string s = "Help I lost myself again";
            StaticOperation.Shortest_word(s);
            obj2.Remove(3);
            obj2.Add(9);
            obj2.Add(15);
            obj2.Display(obj2);
            Console.WriteLine(obj1<obj2);
            Console.WriteLine(obj1 > obj2);
            var cross=obj1%obj2;
            Console.WriteLine(cross);
            Console.WriteLine(obj1!= obj2);
            Console.WriteLine(obj1 == obj2);
            Console.ReadLine();
        }
    }
}
