using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood
{
    public class ProductChicken : IProduct
    {
        public ProductChicken(int Quantity)
        {
            this.Quantity = Quantity;
        }
        public string Name { get => "Frango"; }
        public double Value { get => 16.0; }
        private int _Quantity = 0;
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public double Price()
        {
            return Quantity * Value;
        }
    }
}
