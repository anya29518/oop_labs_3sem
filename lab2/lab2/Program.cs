using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
        //1
            //a
            sbyte a=1;
                Console.WriteLine($"a={a}");
            short b=2;
                Console.WriteLine($"b={b}");
            int c=3;
                Console.WriteLine($"c={c}");
            long d=4;
                Console.WriteLine($"d={d}");
            byte e=5;
                Console.WriteLine($"e={e}");
            ushort f=6;
                Console.WriteLine($"f={f}");
            uint g=7;
                Console.WriteLine($"g={g}");
            ulong h=8;
                Console.WriteLine($"h={h}");
            char i='9';
                Console.WriteLine($"i={i}");
            bool j=true;
                Console.WriteLine($"j={j}");
            float k=10;
                Console.WriteLine($"k={k}");
            double l=11;
                Console.WriteLine($"l={l}");
            decimal m=12;
                Console.WriteLine($"m={m}");
            string n="13";
                Console.WriteLine($"n={n}");
            Object o = new Object();
                Console.WriteLine($"o={o}");
            //b
            byte x = 18;

            Int16 r = (Int16)x;
            Int32 s = (Int32)x;
            Int64 q = (Int64)x;
            Single t = (Single)x;
            Double p = (Double)x;

            short y = 0;

            Int32 u = y;
            Int64 v = y;
            Single w = y;
            Double z = y;
            Decimal s0 = y;
            //c
            int ps = 100;
            Object a0 = ps;
            double t0 = (double)(int)a0;
            Console.WriteLine($"t0={t0}");
            //d
            var q0 = "1234567890";
            Object r0 = q0;
            Console.WriteLine(r0.GetType());
            var arr = new[] { 12, 3, -6, 98, 25, 57 };
            Console.WriteLine(arr.GetType());
            var arr1 = new[] { 11.4, 78, 22.67 };
            Console.WriteLine(arr1.GetType());
            //e
            int? nul = null;
            int? nul1 = nul ?? 1;
            Console.WriteLine(nul1);
            int? nul2 = nul1 ?? 456;
            Console.WriteLine(nul2);
        //2
            //a
            string str = "abcdef", str1 = "111 222",
            str2 = "  a word ", str3 = "!@#$%^&*()_+-=,.?";
            bool res;
            res = str == str1;
            Console.WriteLine();
            Console.WriteLine($"res= {res}");
            res = str1 != str2;
            Console.WriteLine($"res= {res}");
            int result;
            result = String.Compare(str, str1);
            Console.WriteLine($"result= {result}");
            result = String.CompareOrdinal(str1, str2);
            Console.WriteLine($"result= {result}");
            result = str2.CompareTo(str3);
            Console.WriteLine($"result= {result}");
            result = String.Compare(str, "abcdef");
            Console.WriteLine($"result= {result}");
            //b
            String word = "I'm ";
            String name = "Anna ";
            String surname = "Kravchenko";
            String words = String.Concat(word, name, surname);
            Console.WriteLine(words);
            Console.WriteLine(String.Copy(words.ToUpper()));
            String words1 = words.Substring(4, 15);
            Console.WriteLine(words1);
            string[] words2 = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string wd in words2)
            Console.WriteLine(wd);
            Console.WriteLine(words.Insert(7, "y").Remove(6,1));
            //c
            string empty_str = "";
            string null_str = null;
            Console.WriteLine("***Empty string***");
            Console.WriteLine(empty_str.Length);
            Console.WriteLine(empty_str == string.Empty);
            Console.WriteLine(String.IsNullOrEmpty(empty_str));
            Console.WriteLine("***Null string***");
            Console.WriteLine(null_str == string.Empty);
            Console.WriteLine(String.IsNullOrEmpty(null_str));
            //d
            StringBuilder sb = new StringBuilder("a word");
            Console.WriteLine();
            Console.WriteLine(sb);
            Console.WriteLine(sb.Remove(0, 1).Insert(0, "hello").Insert(9, "l").Append("!"));
        //3
            //a
            int[,] matr = { { 1, 3, 5 }, { 2, 4, 6 }, { 7, 9, 11 }, { 8, 10, 12 } };
            int height = matr.GetLength(0);
            int width = matr.GetLength(1);
            for (int i1=0; i1 < height; i1++)
            {
                for (int j1=0; j1 < width; j1++)
                {
                    Console.Write(matr[i1, j1] + "\t");
                }
                Console.WriteLine();
            }
            //b
            string[] song = {"falling too fast to prepare for this",
                             "tripping in the world could be dangerous",
                             "everybody circling, it's vulturous",
                             "negative, neposit" };
            foreach (var line in song)
                Console.WriteLine(line);
            Console.WriteLine(song.Length);
            Console.WriteLine("Введите номер строки для изменения: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите текст:");
            string newline = Console.ReadLine();
            for(int i2=0; i2 < song.Length; i2++)
            {
                if(i2==numb-1)
                {
                    song[i2] = newline;
                }
            }
            Console.WriteLine();
            foreach (var line in song)
                Console.WriteLine(line);
            //c
            float[][] st = new float[3][];
            st[0] = new float[2];
            st[1] = new float[3];
            st[2] = new float[4];
            for (int i3 = 0; i3 < 3; i3++)
            {
                for (int j3 = 0; j3 < st[i3].Length; j3++)
                {
                    st[i3][j3] = Convert.ToSingle(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i3 = 0; i3 < 3; i3++) 
            {
                for (int j3 = 0; j3 < st[i3].Length; j3++)
                {
                    Console.Write(st[i3][j3]+"\t");
                }
                Console.WriteLine();
            }
            //d
            var xx = "help";
            var yy = new[]{ 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            //4
            //a
            (int, string, char, string, ulong) inf = (1, "text", 'u', "also text", 123);
            //b
            Console.WriteLine($"{inf}");
            Console.WriteLine($"{inf.Item1}, {inf.Item2}, {inf.Item5}");
            //c
            (string, int, char) cort = ("one", 2, '3'),cort2=("abcdefghijklmn",0,'p');
            var (one, two, three) = cort;
            Console.WriteLine($"{one}, {two}, {three}");
            //d
            Console.WriteLine(cort.CompareTo(cort2));
            //5
            int[] arrr = { 18, 6, 2002 };
            string sss= "nothing";
            (int,int,int,char)locFunction(string ss, int[] arr0)
                {
                return (arr0.Min(),arr0.Max(),arr0.Sum(),ss.First());
                }
            Console.WriteLine(locFunction(sss, arrr));
            Console.WriteLine("end");
            System.Console.ReadLine();
        }
    }
}
