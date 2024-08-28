namespace Padaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var productRepository = new ProductRepository();
                var product = new Product() { Name = "Coxinha", Price = 8.00 };
                Console.WriteLine(product.ToString());
                productRepository.Create(product);
                productRepository.Create(new Product() { Name = "Coca-Cola", Price = 6.00 });

                var prodTicket = new ProductTicket() { Product = product, Quantity = 2 };
                var secondPT = new ProductTicket() { Product = productRepository.Read(2), Quantity = 1 };
                Console.WriteLine(prodTicket.ToString());

                var client = new LoyalCustomer() { Name = "Lucas", Cpf = "12345678903" };
                Console.WriteLine(client.ToString());
                var pagamento = new FormasPagamento() { name = "Credito", bandeira = "Mastercard" };

                var ticketRepository = new TicketRepository();
                var ticket = new Ticket() { Client = client, PaymentType = pagamento };
                ticket.AddProduct(prodTicket);
                ticket.AddProduct(secondPT);
                ticketRepository.Create(ticket);

                Console.WriteLine("Valor total do ticket: " + ticket.TotalValue());
                Console.WriteLine(client.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
