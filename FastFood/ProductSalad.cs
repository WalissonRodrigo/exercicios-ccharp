using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood
{
    public class ProductSalad : IProduct
    {
        public ProductSalad(int Quantity)
        {
            this.Quantity = Quantity;
        }
        public string Name { get => "Salada"; }
        public double Value { get => 2.0; }
        private int _Quantity = 0;
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public double Price()
        {
            return Quantity * Value;
        }
    }
}
