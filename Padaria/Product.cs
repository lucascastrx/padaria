using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private double _price;
        public double Price { 
            get {
                return this._price;
            }
            set { 
                if(value < 0)
                    throw new ArgumentException("Value can't be negative.");
                this._price = value;
            } 
        }

        public string ToString()
        {
            return $"Nome: {Name}, Preço: {Price}";
        }
    }
}
