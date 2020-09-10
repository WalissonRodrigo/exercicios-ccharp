using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood
{
    public class ProductMeat : IProduct
    {
        public ProductMeat (int Quantity)
        {
            this.Quantity = Quantity;
        }
        public string Name { get => "Carne"; }
        public double Value { get => 20.0; }
        
        private int _Quantity = 0;
        public int Quantity { get => _Quantity; set => _Quantity = value; }

        public double Price()
        {
            return Quantity * Value;
        }
    }
}
