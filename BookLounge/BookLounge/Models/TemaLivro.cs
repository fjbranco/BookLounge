using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLounge.Models
{
    /// <summary>
    /// Relação de Livros com Temas de Muitos para Muitos
    /// </summary>
    public class TemaLivro
    {
        /// <summary>
        /// PK para a classe de relacionamento entre Livros e Temas
        /// </summary>
        [Key]
        public int Id { get; set; }

        // ***************************************************

        /// <summary>
        /// FK para o Tema
        /// </summary>
        [ForeignKey(nameof(Tema))]
        public int TemaFK { get; set; }
        public Tema Tema { get; set; }

        /// <summary>
        /// FK para o Livro
        /// </summary>
        [ForeignKey(nameof(LivroT))]
        public int LivroTFK { get; set; }
        public Livro LivroT { get; set; }
    }
}
