using System.ComponentModel.DataAnnotations;

namespace BookLounge.Models
{
    /// <summary>
    /// Descrição dos Temas dos Livros
    /// </summary>
    public class Tema
    {

        public Tema()
        {
            // Inicializar a lista de Livros de cada um dos Temas
            ListaLivros = new HashSet<TemaLivro>();
        }

        /// <summary>
        /// Identificador de cada um dos Temas do Livro
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Designa o tema do livro
        /// </summary>
        [StringLength(40, ErrorMessage = "O {0} não deve ter mais de {1} caracteres!")]
        public string DesignacaoTema { get; set; }

        // ###################################################

        /// <summary>
        /// Lista de Monumentos associados às Características
        /// </summary>
        public ICollection<TemaLivro> ListaLivros { get; set; }

    }
}
