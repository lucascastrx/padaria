

namespace Padaria
{
    internal class CustomerRepository : IRepository<int, Customer>
    {

        public List<Customer> Customers { get; set; } = new();
        private static int CUSTOMER_ID = 0;
        public Customer Create(Customer Data)
        {
            Data.Id = CUSTOMER_ID;
            Customers.Add(Data);
            return Data;
        }

        public void Delete(int Id)
        {
            var Customer = Customers.Find(c => c.Id == Id);

            if (Customer == null)
            {
                throw new ArgumentException("User Not Found");
            }

            Customers.Remove(Customer);

        }

        public Customer Read(int Id)
        {
            var Customer = Customers.Find(c => c.Id == Id);

            if (Customer == null)
            {
                throw new ArgumentException("User Not Found");
            }

            return Customer;
        }

        public Customer Update(int Id, Customer data)
        {
            var Customer = Customers.Find(c => c.Id == Id);

            if (Customer == null)
            {
                throw new ArgumentException("User Not Found");
            }

            var Index = Customers.IndexOf(Customer);

            Customers.Remove(Customer);

            Customers.Insert(Index, data);

            return Customers[Index];
        }
    }
}
