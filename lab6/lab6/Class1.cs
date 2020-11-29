using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    abstract partial class Tech: Product, IWrite
    {
        public Tech()
        {
            count++;
        }
        void IWrite.Sum()
        {
            Console.WriteLine("Всего техники: " + count);
        }
    }
    class Class1
    {

    }
}
