using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apartment.ApartmentMaterials; // Using this namespace so i can use the data from it

namespace Apartment.Materials
{
    internal class Interior : SetInterior
    {
        // Fields
        private int door;
        private string window;

        // Constructor
        public Interior(int door, string window)
        {
            this.door = door;
            this.window = window;
        }

        // Properties
        public int Doors
        {
            get { return door; }
            set { door = value; }
        }
        public string Windows
        {
            get { return window; }
            set { window = value; }
        }
        
        // Method for setting doors for apartment
        public override void SetDoors()
        {
            // code
        }

        // Method for setting windows for apartment
        public override void SetWindows()
        {
            // code
        }
    }
}
