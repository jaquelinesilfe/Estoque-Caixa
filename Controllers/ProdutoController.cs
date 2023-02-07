using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Estoque_Caixa.Context;
using Estoque_Caixa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Estoque_Caixa.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly OrganizadorContext _context;

        public ProdutoController(OrganizadorContext context)
        {
            _context= context;
        }

        public IActionResult Index()
        {
            var produtos = _context.Produtos.ToList();
            return View(produtos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Produto produto)
        {

            if (ModelState.IsValid)
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        public IActionResult Editar(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null)
                return RedirectToAction(nameof(Index));

            return View(produto);
        }

        [HttpPost]
        public IActionResult Editar(Produto produto)
        {
            var produtoBanco = _context.Produtos.Find(produto.Id);

            produtoBanco.Nome = produto.Nome;
            produtoBanco.Descricao = produto.Descricao;
            produtoBanco.Marca = produto.Marca;
            produtoBanco.Quantidade = produto.Quantidade;
            produtoBanco.PrecoUnit  = produto.PrecoUnit;
            produtoBanco.CodBarras = produto.CodBarras;
            produtoBanco.DataCadastro = produto.DataCadastro;
            produtoBanco.StatusProduto = produto.StatusProduto;

            _context.Produtos.Update(produtoBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Detalhes(int id)
        {
            var produto = _context.Produtos.Find(id);

            if (produto == null)
                return RedirectToAction(nameof(Index));

            return View(produto);
        }

        public IActionResult Deletar(int id)
        {
            var produto = _context.Produtos.Find(id);

            if (produto == null)
                return RedirectToAction(nameof(Index));

            return View(produto);
        }

        [HttpPost]
        public IActionResult Deletar(Produto produto)
        {
            var produtoBanco = _context.Produtos.Find(produto.Id);
            _context.Produtos.Remove(produtoBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        // [HttpGet("{id}")]
        // public IActionResult ObterPorId(int id)
        // {
        //     var produto = _context.Produtos.Find(id);
        //     if (produto == null)
        //     return NotFound();

        //     return Ok(produto);
        // }

        // [HttpGet("ObterTodos")]
        // public IActionResult ObterTodos()
        // {
    
        //     var produto = _context.Produtos.ToList();
        //     return Ok(produto);
        // }

        // [HttpGet("ObterPorNome")]
        // public IActionResult ObterPorNome(string nome)
        // {

        //     var produto = _context.Produtos.Where(x => x.Nome.Contains(nome));
        //     return Ok(produto);
        // }

        // [HttpGet("ObterPorDataCadastro")]
        // public IActionResult ObterPorDataCadastro(DateTime data)
        // {
        //     var produto = _context.Produtos.Where(x => x.DataCadastro.Date == data.Date);
        //     return Ok(produto);
        // }

        // // [HttpGet("ObterPorStatus")]
        // // public IActionResult ObterPorStatus(EnumStatusTarefa status)
        // // {
    
        // //     var tarefa = _context.Produtos.Where(x => x.Status == status);
        // //     return Ok(tarefa);
        // // }

        // [HttpPost]
        // public IActionResult Criar(Produto produto)
        // {
        //     if (produto.DataCadastro == DateTime.MinValue)
        //         return BadRequest(new { Erro = "A data do cadastro do produto não pode ser vazia" });

            
        //     _context.Add(produto);// TODO: Adicionar a tarefa recebida no EF e salvar as mudanças (save changes)  
        //     _context.SaveChanges();
        //     return CreatedAtAction(nameof(ObterPorId), new { id = produto.Id }, produto);
        // }

        // [HttpPut("{id}")]
        // public IActionResult Atualizar(int id, Produto produto)
        // {
        //     var produtoBanco = _context.Produtos.Find(id);

        //     if (produtoBanco == null)
        //         return NotFound();

        //     if (produto.DataCadastro == DateTime.MinValue)
        //         return BadRequest(new { Erro = "A data do cadastro do produto não pode ser vazia" });

        //     produtoBanco.Descricao = produto.Descricao;
        //     produtoBanco.DataCadastro = produto.DataCadastro;
        //     //produtoBanco.Status = produto.Status;

        //     _context.Produtos.Update(produtoBanco);
        //     _context.SaveChanges();
        //     return Ok();
        // }

        // [HttpDelete("{id}")]
        // public IActionResult Deletar(int id)
        // {
        //     var tarefaBanco = _context.Produtos.Find(id);
        //     if (tarefaBanco == null)
        //         return NotFound();

        //     _context.Produtos.Remove(tarefaBanco);
        //     _context.SaveChanges();
        //     return NoContent();
        // }
    }
}