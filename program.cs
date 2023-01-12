using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overriding = provides a new ver of method inherited from a parent classs
            //                    inherited method must be abstract, virtual, or alreadu overrident
            //                   used with toStrinng(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();





            Console.ReadKey();

        }

    }
  
     class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The anime go #brrr# ");
        }
    }
     class Dog :Animal
    {
        public override void Speak()
        {
            Console.WriteLine("dog wooooaf");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine(" cat meow");
        }
    }




}







