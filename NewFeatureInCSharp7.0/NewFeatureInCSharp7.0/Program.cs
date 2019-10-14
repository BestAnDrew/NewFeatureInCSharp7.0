using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatureInCSharp7._0
{
    class Program
    {
        static void Main(string[] args)
        {


            // feature 1: out variable declared inline   out标识符   该标识符可以不用初始化一个变量而直接使用
            Console.WriteLine("what is you age:");
            String argText = Console.ReadLine();

            // Old way 
            //int age = 0;
            //bool isValid = int.TryParse(argText, out age);

            // new way
            //bool isValidNew = int.TryParse(argText, out int agenew);


            //feature 2: pattern matching 
            String age1 = "42";
            int age2 = 82;

            object ageVal1 = age1;
            if (ageVal1 is int age || (ageVal1 is String agep2 && int.TryParse(agep2, out age)))
            {
                Console.WriteLine($"{age}");
            }

            object ageVal2 = age2;
            if (ageVal2 is int age3 || (ageVal2 is String agep3 && int.TryParse(agep3, out age3)))
            {
                Console.WriteLine($"{age3}");
            }

            //feature 3 : Powerful Switch Statement
            //Employees e1 = new Employees() { MyProperty = 1, MyProperty2 = 2 };
            //Employees e2 = new Employees() { MyProperty = 2, MyProperty2 = 1 };

            //List<object> list = new List<object>() { e1, e2 };


            //foreach (var item in list)
            //{
            //    switch (item)
            //    {
            //        case Employees e when (e.MyProperty == 1):
            //            Console.WriteLine($"{e.MyProperty}");
            //            break;
            //        case Employees e when (e.MyProperty2 == 1):
            //            Console.WriteLine($"{e.MyProperty2}");
            //            break;
            //        default:
            //            break;
            //    }
            //}

            //feature 4 : throw is expression
            Employees e1 = new Employees() { MyProperty = 1, MyProperty2 = 2 };
            Employees e2 = new Employees() { MyProperty = 2, MyProperty2 = 1 };

            List<Employees> list = new List<Employees>() { e1, e2 };

            Employees ee = list.Where(x => x.MyProperty == 2).FirstOrDefault() ?? throw new Exception("some error is happen");

            //feature 5: tuples
            var name = sortlist("1");
            Console.WriteLine($"{name.a}{name.b}");


        }
        public static (string a, int b) sortlist(string name)
        {
            String c = "1";
            int d = 5;
            return (c, d);
        }

    }
    
    public class Employees
    {
        public int MyProperty { get; set; }

        public int MyProperty2 { get; set; }
    }
}
