using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    internal class StandardCustomer : Customer
    {
        public override void CalculatePoints(double PurchaseTotalPrice){}

        public string ToString()
        {
            return $"Nome: {Name}";
        }
    }
}
