using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood
{
    public interface IProduct 
    {
        public string Name { get; }
        public double Value { get; }

        public int Quantity { get; set; }

        public double Price();
    }
}
