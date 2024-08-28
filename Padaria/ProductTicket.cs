using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Padaria
{
    internal class ProductTicket
    {
        public int Id { get; set; }
        public Product Product { get; set; }

        private int _quantity;
        public int Quantity
        {
            get { return this._quantity; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Quantity can't be zero or negative.");
                this._quantity = value;
            }
        }

        public double Value()
        {
            return Product.Price * Quantity;
        }

        public string ToString()
        {
            return $"Produto: {Product.ToString()}, Quantidade: {Quantity}, Total: {Value()}";
        }
    }
}
