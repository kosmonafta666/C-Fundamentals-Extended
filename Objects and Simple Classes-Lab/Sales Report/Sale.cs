namespace Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Sale
    {
        private string town;
        private string product;
        private decimal price;
        private decimal quantity;

        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        public string Product 
        {
            get { return product; }
            set { product = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
