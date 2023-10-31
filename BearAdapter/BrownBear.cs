using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearAdapter
{
    public class BrownBear : IBear
    {
        public bool Hibernating { get ; set ; }

        public BrownBear(bool hibernating)
        {
            Hibernating = hibernating;
        }

        public void GoTowards(object objectToWalkTowards)
        {

            if(Hibernating)
                Console.WriteLine($"Bear is hibernating, it can't go to {objectToWalkTowards}");
            else
                Console.WriteLine($"Bear goes to {objectToWalkTowards}");


        }

        public void LookAt(object objectToLookAt)
        {
            if(Hibernating)
                Console.WriteLine($"Bear is hibernating, its eyes are shut");
            else
                Console.WriteLine($"Bear looks at {objectToLookAt}");
        }

        public void Roar()
        {
            if(Hibernating)
                Console.WriteLine("zZzZzZ");
            else
                Console.WriteLine("RAWR");
        }

        public bool TryEat(object objectToEat)
        {
            Console.WriteLine($"Bear tries to eat {objectToEat}");

            if (Hibernating)
            {
                Console.WriteLine($"Bear failed to eat {objectToEat} it's hibernating");
                return true;
            }
            else
            {
                Console.WriteLine($"Bear ate {objectToEat}");
                return false;
            }
                
        }
    }
}