using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apartment.Interface.Doors; // using 2 namespaces from each interface i have
using Apartment.Interface.Windows;

namespace Apartment.ApartmentMaterials
{
    internal abstract class SetInterior : IDoors, IWindows
    {
        // Field
        private string door;
        private string window;

        // Properties
        protected internal string Window
        {
            get { return window; }
            set { door = value; }
        }
        protected internal string Door
        {
            get { return door; }
            set { door = value; }
        }

        // Abstract methods
        public abstract void SetDoors();

        public abstract void SetWindows();
    }
}
