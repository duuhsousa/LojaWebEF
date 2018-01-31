using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaWebEF.Models
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPedido { get; set; }

        [Required]
        public int IdProduto { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public int Quantidade { get; set; }

        /// <summary>
        /// CONFIRMACAO DA FOREIGN KEY NAS TABELAS CLIENTE E PRODUTO
        /// </summary>
        /// <returns></returns>
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
    }
}