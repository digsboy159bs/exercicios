using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController: Controller
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        public IActionResult Index()
        {
            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos();

            return View(pvm);
        }

        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"]= "Pedido";
            Pedido pedido = new Pedido();
            Shake shake = new Shake();
            shake.Nome = form["shake"];
            shake.Preco = 0.0;
            pedido.Shake = shake;

            Hamburguer hamburguer = new Hamburguer();

            pedido.Hamburguer = hamburguer;
            hamburguer.Nome = form["hamburhuer"];
            hamburguer.Preco = 0.0;

            Cliente cliente = new Cliente();
            
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;
            pedido.DataDoPedido = DateTime.Now;
            pedido.PrecoTotal = 0.0;

            if(pedidoRepository.Inserir(pedido))
            {
                return View ("Sucesso");

            }else{
                return View("Erro");
            }



        }
    }
}