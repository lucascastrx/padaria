
namespace Padaria
{
    internal abstract class Customer
    {
        public int  Id{ get; set; }
        public string Name { get; set; } = "";

        public abstract void CalculatePoints(double PurchaseTotalPrice);


    }

}
