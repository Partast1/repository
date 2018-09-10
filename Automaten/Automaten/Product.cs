using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
     class Product
    {

        private string proName;
        private int proPrice;
        private int proQuantity;



        public string ProName
        {
            get
            {
                return this.proName;
            }
            set
            {
                this.proName = value;
            }
        }
        public int ProPrice
        {
            get
            {
                return this.proPrice;
            }
            set
            {
                this.proPrice = value;
            }
        }
        public int ProQuantity
        {
            get
            {
                return this.proQuantity;
            }
            set
            {
                this.proQuantity = value;
            }
        }


        public Product(string ConName, int ConPrice, int ConQuantity)
        {
            this.proName = ConName;
            this.proPrice = ConPrice;
            this.proQuantity = ConQuantity;

        }
        public Product()
        {

        }
    }
}
