using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace App1_7iul17
{
    class Program
    {
        
        const string myFirstConst = "gigi";
        static int myFirstStatic = 0;

        int myFirstField;

        //constructor:
        public Program(int myFirstField)
        {
            myFirstStatic += 1;
            this.myFirstField = myFirstField;
        }
        static void Main(string[] args)
        {

            /*
            int x = 12;
            Program z = new Program();
            var t = 5;
            var k = long.MaxValue;
            */

            var a = new Program(999);
            Console.WriteLine(Program.myFirstStatic + " "+ a.myFirstField);

            var b = new Program(111);
            Console.WriteLine(Program.myFirstStatic + " " + b.myFirstField);
            Console.ReadLine();
            //var aCar = new AbstractCar(); DOESN'T WORK
            var aCar = new ModelS();

            //verificarea Accesibilitatii:
            var class1 = new Class1();
            //class1.MyProtectedMethod(); <-- NU MERGE AICI
            class1.MyPublicMethod();
            //class1.MyInternalMethod(); <-- NU MERGE AICI


        }
    }

    public abstract class AbstractCar : ICar
    {
        public abstract bool Start();
        public bool Stop()
        {
            return false;
        }
    }

    //Interface:
    public interface ICar
    {
        bool Start();
        bool Stop();
    }

    public class ModelS : AbstractCar
    {
        public override bool Start()
        {
            return true;
        }
        public bool Stop()
        {
            return false;
        }
    }

    enum DaysOfWeek
    {
        Monday = 500,
        Tuesday =700,
        Sunday = 400
    }

    struct MySpecialDate
    {
        public uint year;
        public byte month;
        public byte day;
    }

    public class Class3 : Class1
    {
        Class3()
        {
            //this.
        }
    }
}
