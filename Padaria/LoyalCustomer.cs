using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    internal class LoyalCustomer : Customer
    {
        private string _cpf;
        public string Cpf
        {
            get
            {
                return this._cpf;
            }

            set {
                if (value == null || value == "" || value.Length != 11)
                    throw new ArgumentException("Cpf error");
                this._cpf = value;
            }
        }
        public double Points { get; set; } = 0.0;

        public override void CalculatePoints(double PurchaseTotalPrice)
        {
            Points = PurchaseTotalPrice * 0.10;
        }

        public string ToString()
        {
            return $"Nome: {Name}, CPF: {Cpf}, Pontos: {Points}";
        }
    }
}
