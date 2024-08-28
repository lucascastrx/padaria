using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    internal class LoyalCustomer : Customer
    {
        public string Cpf { get; set; } = "";
        public double Points { get; set; } = 0.0;

        public void CalculatePoints(double PurchaseTotalPrice)
        {
            Points = PurchaseTotalPrice * 0.10;
        }
    }
}
