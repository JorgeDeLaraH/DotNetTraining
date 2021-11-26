using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//We use this to work with Vehicle, is necessary add a service preference
using AudioManager;
//This es the workspace
namespace DN_1._1_Jorge_DeLara_v1._1
{
    //This is the name of the base principal class
    internal class Program
    {   
        //This is the structure of the main function his type is void.
        static void Main(string[] args)
        {
            //These instruccions works to display menssages to user in the console
            Console.Write("Hi I'm a program that shows the functionality of Vehicle class\n");
            Console.WriteLine("I'll add the sounds of diferent vehicles the next time");
            
            //We create an object from vehicle.cs
            Vehicle vehicle=new Vehicle();
            //We use one function from Vehicle
            vehicle.VehicleSound();
            //This code has the function of wait one key from the keyboard to finish
            Console.ReadKey();

        }
    }
}
