using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    internal class FormasPagamentoRepository : IRepository<int, FormasPagamento>
    {
        private List<FormasPagamento> formaspagamentos = [];
        private static int FormasPagamento_id;
        public FormasPagamento Create(FormasPagamento Data)
        {
            Data.Id = FormasPagamento_id++;
            formaspagamentos.Add(Data);
            return Data;

        }

        public void Delete(int Id)
        {
            var formaspagamento = formaspagamentos.Find(o => o.Id == Id);
            if (formaspagamento == null)
                throw new Exception("Está forma de Pagamento não existe.");
            formaspagamentos.Remove(formaspagamento);
        }

        public Product Read(int Id)
        {
            var formaspagamento = formaspagamentos.Find(o => o.Id == Id);
            if (formaspagamento == null)
                throw new Exception("Forma de pagamento não encontrada.");
            return formaspagamento;
        }

        public Product Update(int Id, FormasPagamento data)
        {
            var formaspagamento = formaspagamentos.Find(o => o.Id == Id);
            if (formaspagamento == null)
                throw new Exception("Forma de pagamento não encontrada.");
            formaspagamento.name = data.name;
            formaspagamento.bandeira = data.bandeira;
            return formaspagamento;

        }
    }
}