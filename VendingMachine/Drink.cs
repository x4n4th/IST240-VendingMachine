using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Drink : Item
    {
        public double temperature { get; set; }

        public Drink(double temperature, double cost, int count, string name, string[] info, string picture)
            : base(cost, count, name, info, picture) {
                this.temperature = temperature;
        }

        public Drink() {

        }
    }
}
