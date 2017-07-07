using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_7iul17
{
    public interface IDino
    {
        void eat();
        void move();
    }
    abstract class Dino : IDino
    {
        public static int noObj = 0;
        public void eat()
        {
            Console.WriteLine("eat");
        }
        public abstract void move();
    }
    class TRex : Dino {
        string name;
        public TRex(string name)
        {
            this.name = name;
            noObj++;
        }
        public override void move()
        {
            Console.WriteLine("Moves fast");
        }
    }
    class Triceraptop : Dino
    {
        string name;
        public Triceraptop(string name)
        {
            this.name = name;
            noObj++;
        }
        public override void move()
        {
            Console.WriteLine("Moves slowly");
        }
    }
    class Pterodactyl : Dino
    {
        string name;
        public Pterodactyl(string name)
        {
            this.name = name;
            noObj++;
        }
        public override void move()
        {
            Console.WriteLine("Flies");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TRex Bob = new TRex("Bob");
            Triceraptop Michael = new Triceraptop("Michael");
            Pterodactyl John = new Pterodactyl("John");

            Bob.eat();
            Michael.eat();
            John.eat();

            Bob.move();
            Michael.move();
            John.move();



            Console.WriteLine("No. of dinos:" + Dino.noObj);
            Console.ReadLine();
        }
    }
}
