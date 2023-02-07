using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estoque_Caixa.Models.Enums;

namespace Estoque_Caixa.Models
{
    public class Produto
    {


        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnit { get; set; }
        public int CodBarras { get; set; }
        public DateTime DataCadastro { get; set; }
        public StatusProduto StatusProduto { get; set; }
        public int VendaId { get; set; }


        public Produto(int id, string nome, string descricao, string marca, int quantidade, decimal precoUnit, DateTime dataCadastro, int codBarras)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Marca = marca;
            Quantidade = quantidade;
            PrecoUnit = precoUnit;
            DataCadastro = dataCadastro;
            CodBarras = codBarras;
        }

        // public static List<Produto> List<Produto> GetListaProdutos(){
        //     var listaProdutos = new List<Produto>();

        //     listaProdutos.Add(new Produto(""));

        //     return listaProdutos;
        // }

    }
}