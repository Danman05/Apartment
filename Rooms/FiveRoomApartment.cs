using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments
{
    internal class FiveRoomApartment : DefaultApartment
    {
        // Fields
        private int size = 110;
        private int room = 7;

        // Constructor
        public FiveRoomApartment(string livingRoom, string kitchen, string bathroom) :
        base(livingRoom, kitchen, bathroom) // Constructor will use the data from the inherited class DefaultApartment
        {

        }

        // Properites
        protected internal int Size
        {
            get { return size; }
            set { size = value; }
        }
        protected internal int Room
        {
            get { return room; }
            set { room = value; }
        }
    }
}
