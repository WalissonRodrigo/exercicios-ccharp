using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood
{
    public class ProductFries : IProduct
    {
        public ProductFries(int Quantity)
        {
            this.Quantity = Quantity;
        }
        public string Name { get => "Batata Frita"; }
        public double Value { get => 6.0; }
        private int _Quantity = 0;
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public double Price()
        {
            return Quantity * Value;
        }
    }
}
