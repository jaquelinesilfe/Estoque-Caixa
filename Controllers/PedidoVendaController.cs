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
    [ApiController]
    [Route("[controller]")]
    public class PedidoVendaController : ControllerBase
    {
         private OrganizadorContext _context { get; set; }

        public PedidoVendaController(OrganizadorContext context)
        {
            this._context= context;
        }

        // [HttpPost]
        // public IActionResult RegistrarVenda(PedidoVenda venda)
        // {

        //     venda.Status = "Aguardando pagamento";
        //     _context.Vendas.Add(venda);
        //     _context.SaveChanges();
        //     return Created("Venda registrada", venda);
        // }

        // [HttpGet("{id}")]
        // public IActionResult BuscarVenda(int id)
        // {
        //     var venda = _context.Vendas.Find(id);

        //     if (venda == null)
        //         return NotFound();

        //     return Ok(venda);
        // }

        // [HttpPut("{id}")]
        // public IActionResult AtualizarVenda(int id, Venda venda)
        // {
        //     var vendaBanco = _context.Vendas.Find(venda.Id);

        //     if (vendaBanco == null)
        //         return NotFound();

        //     vendaBanco.Status = venda.Status;
            
        //     _context.Vendas.Update(vendaBanco);
        //     _context.SaveChanges();
        //     return Ok();
        
       
    }
}