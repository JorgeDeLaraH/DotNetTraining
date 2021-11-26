using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;//NUGet

namespace OOP.ConsoleExample
{
    internal class Program
    {
        //Principal function
        static void Main(string[] args)
        {
            //While= true repeats the cicle
            while (true)
            {
                //We show text in the console
                Console.WriteLine("Type the animal: ");
                //Create a variable type String to save keyboard users STring
                String animalType = Console.ReadLine().ToLower();
                Animal animal = null;
                //Switch cicle
                switch (animalType)
                {
                    case "cat":
                        animal = new Cat();
                        break;
                    case "cow":
                        animal = new Cow();
                        break;
                    case "dog":
                        animal = new Dog();
                        break;
                    case "elephant":
                        animal = new Elephant();
                        break;
                    case "lion":
                        animal = new Lion();
                        break;
                    case "pig":
                        animal = new Pig();
                        break;
                    default:
                        Console.WriteLine("Animal not found");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }
                
                if (animal != null)
                {
                    animal.AnimalSound();
                }
            }
            Console.ReadKey();
        }
    }
}
