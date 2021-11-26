using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioManager
{//We need public because we have to use these classes
//in all the principal program.
    public class Animal
    {
        //We need virtual to modify the content of father to sons//
        public  virtual void AnimalSound()
        {
            Console.WriteLine("I am an Animal");
        }

    }
}
