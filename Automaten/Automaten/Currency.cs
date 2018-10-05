using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Currency
    {
        private int money;

        public int Money
        {
            get
            {
                return this.money;
            }
            set
            {
                this.money = value;
            }
        }

        public Currency()
        {

        }
        public Currency(int CurrencyCon)
        {
            this.money = CurrencyCon;
        }

        public int SubtractCurrency(int inputmoney)
        {
            money = money - inputmoney;
            return money;
        }
        public int AddCurrency()
        {
            int add = int.Parse(Console.ReadLine());
            money = add + money;
            return money;
        }
    }
}
