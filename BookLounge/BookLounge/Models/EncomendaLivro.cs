using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLounge.Models
{
    /// <summary>
    /// Relação de Livros com Encomendas de Muitos para Muitos
    /// </summary>
    public class EncomendaLivro
    {
        /// <summary>
        /// PK para a classe de relacionamento entre Livros e Encomendas
        /// </summary>
        [Key]
        public int Id { get; set; }

        // ***************************************************

        /// <summary>
        /// FK para a encomenda
        /// </summary>
        [ForeignKey(nameof(Encomenda))]
        public int EncomendaFK { get; set; }
        public Encomenda Encomenda { get; set; }

        /// <summary>
        /// FK para o Livro
        /// </summary>
        [ForeignKey(nameof(Livro))]
        public int LivroFK { get; set; }
        public Livro Livro { get; set; }

    }
}
