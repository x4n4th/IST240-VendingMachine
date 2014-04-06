using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Snack : Item
    {
        public Snack(double cost, int count, string name, string[] info, string picture)
            : base(cost, count, name, info, picture) {

        }

        public Snack() {

        }
    }
}
