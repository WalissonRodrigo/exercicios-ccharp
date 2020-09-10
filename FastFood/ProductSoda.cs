using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood
{
    public class ProductSoda : IProduct
    {
        public ProductSoda(int Quantity)
        {
            this.Quantity = Quantity;
        }
        public string Name { get => "Refrigerante"; }
        public double Value { get => 4.0; }
        private int _Quantity = 0;
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public double Price()
        {
            return Quantity * Value;
        }
    }
}
