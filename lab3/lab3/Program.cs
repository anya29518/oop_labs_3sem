using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    partial class Abiturient
    {
        
        readonly int id;
        const string UO = "BSTU";
        string name, surname, secname, adres;
        int phnumber;
        public int[] marks = new int[3];
        public static int number;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                this.surname = value;
            }
        }
        public string Secname
        {
            get
            {
                return this.secname;
            }
            set
            {
                this.secname = value;
            }
        }
        public string Adres
        {
            get
            {
                return this.adres;
            }
            set
            {
                this.adres = value;
            }
        }
        public int Phnumber
        {
            get
            {
                return this.phnumber;
            }
            set
            {
                this.phnumber = value;
            }
        }
       // private Abiturient()
       //{
       //
       //}
        static Abiturient()
        {
            number = 0;
        }
        public Abiturient(int[]mass)
        {
            number++;
            name = "NAME";
            secname = "SECOND NAME";
            surname = "SURNAME";
            adres = "CITY";
            phnumber = 1;
            marks = mass;
            this.id = Hash(id,name,surname);
        }
        public Abiturient(string name, string secname,string surname,string adres,int phnumber, int[] marks)
        {
            number++;
            this.name = name;
            this.surname = surname;
            this.secname = secname;
            this.adres = adres;
            this.phnumber = phnumber;
            this.marks = marks;
            this.id = Hash(id,name,surname);
        }
        public double ball()
        {
            double sum=0;
            double sr_ball;
            for(int i = 0; i < 3; i++)
            {
                sum += marks[i];
            }
            sr_ball = sum / 3;
            return sr_ball;
        }
        public int Max()
        {
           int max;
           max = marks.Max();
           return max; 
        }
        public int Min()
        {
            int min;
            min = marks.Min();
            return min;
        }
        public void inf()
        {
           
            Console.WriteLine($"Name: {name}\n SecondName:{secname}\n Surname:{surname}\n Adres:{adres}\n" +
                $" PhoneNumber:{phnumber}\n  ID:{id}\n Marks:" );
            for (int i= 0; i < 3; i++)
            {
                Console.Write(marks[i] + "\t");
                    }
            Console.WriteLine($"Srednii ball:{ball()}\n Max mark:{Max()}\n Min:{Min()}");
            Console.WriteLine("\n");
        }
        public int Hash(int id,string name,string surname)
        {
            id = name.GetHashCode() + surname.GetHashCode();
            return id;
        }
        public bool neud()
        {
            int c = 0;
            for (int i = 0; i < 3; i++)
            {
                if (marks[i] < 4)
                {
                    c++;
                }
                if (c > 0)
                {
                    break;
                }
            }
            if (c > 0)
            {
                return true;
            }
            else return false;
        }
        public bool higher_than(int h)
        {
            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                sum += marks[i];
            }
            if (sum > h)
            {
                return true;
            }
            else return false;
        }
        public void sum (ref int[] marks,out int s)
        {   s = 0;
            foreach(int mark in  marks )
            {
                s += mark;
            }
            Console.WriteLine($"{s}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int s, s1, s2, s3, s4, s5, s6;
            int[] Marks = { 1, 2, 3 };
            Abiturient one = new Abiturient(Marks);
            one.inf();
            one.sum(ref Marks, out s);
            int[] IvanMarks = { 6, 6, 6 };
            Abiturient Ivan = new Abiturient("Ivan", "Andreevich", "Kravchenko", "Krichev", 123, IvanMarks);
            Ivan.inf();
            Ivan.sum(ref IvanMarks, out s1);
            int[] KateMarks = { 8, 8, 9 };
            Abiturient Kate = new Abiturient("Kate", "Pavlovna", "Shilova", "Mogilev", 5343627, KateMarks);
            Kate.inf();
            Kate.sum(ref KateMarks, out s2);
            int[] AnnMarks = { 5, 6, 7 };
            Abiturient Ann = new Abiturient("Ann", "Andreevna", "Kravchenko", "Minsk", 2231413, AnnMarks);
            Ann.inf();
            Ann.sum(ref AnnMarks, out s3);
            int[] NikoMarks = { 8, 10, 10 };
            Abiturient Niko = new Abiturient("Niko", "Aleksandrovich", "Ivanov", "Brest", 112332, NikoMarks);
            Niko.inf();
            Niko.sum(ref NikoMarks, out s4);
            int[] StasMarks = { 1, 2, 2 };
            Abiturient Stas = new Abiturient("Stas", "Nikolaevich", "Miheev", "Vitebsk", 76543456, StasMarks);
            Stas.inf();
            Stas.sum(ref StasMarks, out s5);
            int[] VikaMarks = { 4, 3, 5 };
            Abiturient Vika = new Abiturient("Vika", "Sergeevna", "Voronova", "Brest", 23421, VikaMarks);
            Vika.inf();
            Vika.sum(ref VikaMarks, out s6);
            Console.WriteLine(Abiturient.number + " Abiturients");
            object[] list = new object[7];
            {
                list[0] = one;
                list[1] = Ivan;
                list[2] = Kate;
                list[3] = Ann;
                list[4] = Niko;
                list[5] = Stas;
                list[6] = Vika;
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Have bad marks:\n");
            foreach(Abiturient ab in list)
            {
                if (ab.neud())
                {
                    ab.inf();
                }
            }
            int marks_sum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Have more than given:\n");
            foreach (Abiturient ab in list)
            {
                if (ab.higher_than(marks_sum))
                {
                    ab.inf();
                }
            }
             Console.ReadLine();

        }
    }
}
