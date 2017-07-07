using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassLibrary1;

namespace App4_7iul17
{
    class Program
    {
        static void Main(string[] args)
        {

            //var myClass = new MyClass();
            //myClass.MyIntProperty = 12;
            //myClass.MyStringProperty = "Imi este fomita";

            //Console.WriteLine(myClass.MyIntProperty);
            //Console.WriteLine(myClass.MyStringProperty);

            //Console.WriteLine(myClass[1]);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //var x = String.Format("test{0}{1}", "1","Robert");
            //Console.WriteLine(x);

            //Console.WriteLine(myClass.ToString());

            ////DateTime:
            //var culture = new CultureInfo("ro-RO");
            //var dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToString(culture));

            ////Currency:
            //var culture2 = new CultureInfo("ro-RO");
            //decimal d = 1.5M;
            //Console.WriteLine(d.ToString("C",culture2)); //C vine de la currency

            ////if we have an int, and we want to print it as a decimal:
            //int i = 1;
            //Console.WriteLine(i.ToString("#.00", culture2));

            ////string parsing
            //int g;
            //var tri = int.TryParse(Console.ReadLine(), out g); 
            //Console.WriteLine(tri);

            ////Defaults:
            //Console.WriteLine(default(DateTime));

            //Method extentions:
            /*
            var myClass1 = new MyClass1("Test");
            Console.WriteLine(myClass1.GetMyString());

            var s = "test";
            s.GetValue();
            */


            ////exceptions:
            //int triu=0;
            //try
            //{
            //    throw new MyException();
            //    triu = int.Parse(Console.ReadLine());
            //}
            //catch(MyException)
            //{
            //    Console.WriteLine("Error!!!!");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine(triu);

            //Console.ReadLine();

            ////Arrays:
            //int[] v1 = new int[20] ;
            //int[,] v2 = new int[20, 20];
            //int[][] v3 = new int[20][];

            //v3[0] = new int[20]; //pentru fiecare element

            ////for
            //for(int i = 0;i < v1.Length; i++){
            //    //some code
            //}

            //foreach (int j in v2)
            //{
            //    Console.WriteLine(j);
            //}

            List<int> v = new List<int>();
            v.Add(1);
            v.Add(2);
            v.Insert(2, 5);

            foreach(int z in v){
                Console.WriteLine(z);
            }

            //contol flow:

            MyEnum x = MyEnum.Value1;
            switch (x)
            {
                case MyEnum.Value1:
                    Console.WriteLine((int)MyEnum.Value1);
                    break;
                case MyEnum.Value2:
                    Console.WriteLine((int)MyEnum.Value2);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            int a = 1;
            int b = 2;
            b += a;
            Console.WriteLine(b);
            b = 2;
            b = +a;
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
    public enum MyEnum {
        Value1 = 0, Value2 = 1, Value3 = 2
    };
    /*
    public static class MyExtention
    {
        public static int GetMyInt(this Class1 c)
        {
            return c.GetMyString().Parse();
        }
        public static int GetValue(this String s)
        {
            return s.Length;
        }
    }
    */
    public class MyException : Exception { }
    
    public class MyClass
    {
        private int myIntProperty;
        public override string ToString()
        {
            return MyStringProperty;
        }
        public int MyIntProperty
        {
            get {
                Console.WriteLine("calling getter");
                return myIntProperty;
            }
            set {
                Console.WriteLine("calling setter");
                myIntProperty = value;
            }
        }
        public int this[int i]
        {
            get
            {
                return i;
            }
        } 
        public string MyStringProperty { get; set; }
    }
}
