using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estoque_Caixa.Models.Enums;

namespace Estoque_Caixa.Models
{
    public class PedidoVenda
    {
        public int PedidoVendaId { get; set; }
        public DateTime DataVenda { get; set; }
        public StatusVenda StatusPedido { get; set; }

        public List<Produto> Produtos { get; set; }


    }
}