using System;

namespace InheritanceDemo
{
  
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

   
    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Puppy is weeping.");
        }
    }

    class Program
    {
        public static void Main()
        {
            Puppy myPuppy = new Puppy();
            myPuppy.Eat();    
            myPuppy.Bark();  
            myPuppy.Weep();   
            Console.ReadKey();
        }
    }
}
