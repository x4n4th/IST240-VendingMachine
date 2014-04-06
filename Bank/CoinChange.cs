using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CoinChange
    {
        //protect the data
        public int Dollar { get; set; }
        public int penny { get; set; }
        public int Nickel { get; set; }
        public int Dime { get; set; }
        public int Quarter { get; set; }

        //constructor
        public CoinChange(int dollar, int penny, int coin1, int coin2, int coin3) {
            this.Dollar = dollar;
            this.penny = penny;
            this.Nickel = coin1;
            this.Dime = coin2;
            this.Quarter = coin3;
        }
    }
}
