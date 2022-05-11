using System.ComponentModel.DataAnnotations;

namespace BookLounge.Models
{
    /// <summary>
    /// Descrição dos Temas dos Livros
    /// </summary>
    public class Genero
    {

        public Genero()
        {
            // Inicializar a lista de Livros de cada um dos Temas
            ListaLivros = new HashSet<Livro>();
        }

        /// <summary>
        /// Identificador de cada um dos Géneros do Livro
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Designa o Género do livro
        /// </summary>
        [StringLength(40, ErrorMessage = "O {0} não deve ter mais de {1} caracteres!")]
        public string DesignacaoGenero { get; set; }

        // ###################################################

        /// <summary>
        /// Lista de Monumentos associados às Características
        /// </summary>
        public ICollection<Livro> ListaLivros { get; set; }

    }
}
