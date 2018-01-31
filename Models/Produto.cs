using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaWebEF.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduto { get; set; }

        [Required(ErrorMessage="Você deve inserir o nome do produto.")]
        [StringLength(100,MinimumLength=2)]
        public string NomeProduto { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Required]
        public int Quantidade { get; set; }

        /// <summary>
        /// DEFINIÇãO DA FOREIGN KEY COM A TABELA PEDIDOS
        /// </summary>
        /// <returns></returns>
        public ICollection<Pedido> Pedido { get; set; }
    }
}