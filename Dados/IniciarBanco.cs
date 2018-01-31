using System.Linq;
using LojaWebEF.Models;

namespace LojaWebEF.Dados
{
    public class IniciarBanco
    {
        public static void Inicializar(LojaContexto contexto){
            //TESTANDO SE O BANCO JA EXISTE.
            contexto.Database.EnsureCreated();
            //ABAIXO ESTAMOS TESTANDO AS RELACOES DO BANCO COM UM CADASTRO FICTICIO.
            if(contexto.Cliente.Any()){
                return;
            }

            var cliente = new Cliente(){
                Nome = "João", Email = "joao@terra.com.br",Idade = 23
            };
            contexto.Cliente.Add(cliente);

            var produto = new Produto(){
                NomeProduto = "Mouse", Descricao = "Mouse Microsoft", Preco = 25.30M, Quantidade = 50
            };
            contexto.Produto.Add(produto);

            var pedido = new Pedido(){
                IdProduto = produto.IdProduto, IdCliente = cliente.IdCliente, Quantidade = 60
            };
            contexto.Pedido.Add(pedido);

            contexto.SaveChanges();
        }
    }
}