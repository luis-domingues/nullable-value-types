using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEspeciaisDotnet.Models
{
    internal class Vendas
    {
        public Vendas(int id, string nomeProduto, decimal preco, DateTime dataVenda) 
        {
            Id = id;
            NomeProduto = nomeProduto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto {  get; set; }
    }
}
