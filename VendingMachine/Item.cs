using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{   
    [Serializable]
    public abstract class Item
    {
        public int count {get; set;}
        public double cost { get; set; }
        public string name { get; set; }
        public string[] info { get; set; }
        public string picture { get; set; }

        /// <summary>
        ///     Represents an item within the vending machine
        /// </summary>
        /// <param name="cost">Cost of item</param>
        /// <param name="count">How many items are in the inventory</param>
        /// <param name="name">Name of item</param>
        /// <param name="point">Point at which to draw the item</param>
        /// <param name="info">Any info about the item such as Dietary information</param>
        /// <param name="picture">Location of items picture</param>
        public Item(double cost, int count, string name, string[] info, string picture) {
            this.cost = cost;
            this.count = count;
            this.name = name;
            this.info = info;
            this.picture = picture;
        }

        public Item() {

        }
    }
}
