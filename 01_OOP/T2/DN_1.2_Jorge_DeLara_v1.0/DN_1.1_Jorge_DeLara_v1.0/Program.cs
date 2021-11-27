using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//We use this to work with Vehicle, is necessary add a service preference
using AudioManager;
//This es the workspace
namespace DN_1._2_Jorge_DeLara_v1._0
{
    //This is the name of the base principal class
    internal class Program
    {   
        //This is the structure of the main function his type is void.
        static void Main(string[] args)
        {
            //I create a counter for the while cicle
            int cont=0;
            //While cont<10 cicles then...
            while (cont < 10)
            {
                Console.WriteLine("Type the Vehicle(Bus, Airplane, Car and Train)");
                String vehicleType = Console.ReadLine().ToLower();
                Vehicle vehicle = null;
                //We create one option for every case of my vehicle sons
                switch (vehicleType)
                {
                    case "train":
                        vehicle = new Train();
                        //We going to increase the counter in one every cicle
                        cont++;
                        break;
                    case "car":
                        vehicle = new Car();
                        break;
                    case "airplane":
                        vehicle=new Airplane();
                        break;
                    case "bus":
                        vehicle = new Bus();
                        break;

                    default:
                        Console.WriteLine("Vehicle not found");
                        System.Threading.Thread.Sleep(200);
                        cont++;
                        break;
                }
                if(vehicle != null)
                {
                    vehicle.VehicleSound();
                }
            }

            Console.ReadKey();

        }
    }
}
