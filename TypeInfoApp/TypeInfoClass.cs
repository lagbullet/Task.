using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeInfoApp
{
    class TypeInfoClass
    {

        public string ClassName { get; set; }

        public TypeInfoClass(string classname)
        {
            ClassName = classname;
        }

        public void ShowMethods()
        {
            Type type = Type.GetType(ClassName);
            Console.WriteLine("--Methods of {0} class--", type.Name);
            foreach (MethodInfo method in type.GetMethods())
                Console.WriteLine(method);
        }

        public void ShowConstructors()
        {
            Type type = Type.GetType(ClassName);
            Console.WriteLine("--Constructors of {0} class--", type.Name);
            foreach (ConstructorInfo Constructor in type.GetConstructors())
                Console.WriteLine(Constructor);
        }

        public void ShowProperties()
        {
            Type type = Type.GetType(ClassName);
            Console.WriteLine("--Properties of {0} class--", type.Name);
            foreach (PropertyInfo Props in type.GetProperties())
                Console.WriteLine(Props);
        }

        public void ShowFields()
        {
            Type type = Type.GetType(ClassName);
            Console.WriteLine("--Fields of {0} class--", type.Name);
            foreach (FieldInfo Fields in type.GetFields())
                Console.WriteLine(Fields);
        }
        public void ShowAll()
        {
            ShowMethods();
            ShowConstructors();
            ShowProperties();
            ShowFields();
        }
    }
}
