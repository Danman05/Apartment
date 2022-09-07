using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments
{
    internal class DefaultApartment 
    {
                                        // Basic template for all other apartment room classes
        // Fields
        private string livingRoom;
        private string kitchen;
        private string bathroom;

        // Constructor
        public DefaultApartment(string livingRoom, string kitchen, string bathroom)
        {
            this.livingRoom = livingRoom;
            this.kitchen = kitchen;
            this.bathroom = bathroom;
        }

        // Properties
        protected internal string LivingRoom 
        { 
            get { return livingRoom; }
            set { livingRoom = value; }
        }
        protected internal string Kitchen 
        { 
            get { return kitchen; } 
            set { kitchen = value; } 
        }
        protected internal string Bathroom 
        { 
           get { return bathroom; }
           set { bathroom = value; } 
        }
    }
}
