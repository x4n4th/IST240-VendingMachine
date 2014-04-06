using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Service
    {
        public static CoinChange TotalChange(decimal sodaCost, decimal amountDeposited) {
            CoinChange CC = new CoinChange(0, 0, 0, 0, 0);

            decimal TotalChange = amountDeposited - sodaCost;

            while (TotalChange > 0) {
                if (TotalChange >= 1.00M) {
                    CC.Dollar++;
                    TotalChange -= 1.00M;
                }
                else if (TotalChange >= .25M) {
                    CC.Quarter++;
                    TotalChange -= .25M;
                }
                else if (TotalChange >= .10M) {
                    CC.Dime++;
                    TotalChange -= .10M;
                }
                else if (TotalChange >= .05M) {
                    CC.Nickel++; ;
                    TotalChange -= .05M;
                }
                else if (TotalChange >= .01M) {
                    CC.penny++; ;
                    TotalChange -= .01M;
                }
            }
            return CC;
        }
    }
}
