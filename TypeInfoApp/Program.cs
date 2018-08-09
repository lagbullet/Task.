using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            TypeInfo Info = new TypeInfo("TypeInfoApp.TypeInfo");
            Info.ShowAll();
            Console.ReadKey();
        }
    }
}
