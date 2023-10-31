using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearAdapter
{
    public class BearAdapter : IDog
    {
        private IBear bear;
        private readonly Random rng;

        public void Bark()
        {
            TryToggleHibernation();
            
            bear.Roar();
        }

        public void Fetch(object objectToFetch)
        {
 
            TryToggleHibernation();           
            
            bear.LookAt(objectToFetch);
            bear.GoTowards(objectToFetch);
            bear.TryEat(objectToFetch);
        }

        private void TryToggleHibernation()
        {


            if(rng.NextDouble() < 0.2)
            {
                bear.Hibernating = !bear.Hibernating;
            }

        }

        public BearAdapter(IBear bear)
        {
            this.bear = bear;
            rng = new Random();
            
        }
    }
}