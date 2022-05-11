using System.ComponentModel.DataAnnotations;

namespace BookLounge.Models
{
    /// <summary>
    /// Livros registados na aplicação
    /// </summary>
    public class Livro
    {
        public Livro()
        {
            // Inicializar a lista de Encomendas de cada um dos Livros
            ListaEncomendas = new HashSet<EncomendaLivro>();
            // Inicializar a lista de Géneros de cada um dos Livros
            ListaTemas = new HashSet<Genero>();
        }

        /// <summary>
        /// Identificador de cada um dos Livros
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Define o Título do Livro
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(35, ErrorMessage = "O {0} deve ter até {1} caracteres!")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        /// <summary>
        /// Define o Autor do Livro
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(35, ErrorMessage = "O {0} deve ter até {1} caracteres!")]
        [Display(Name = "Autor")]
        public string Autor { get; set; }

        /// <summary>
        /// Define a Editora do Livro
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(35, ErrorMessage = "O {0} deve ter até {1} caracteres!")]
        [Display(Name = "Editora")]
        public string Editora { get; set; }

        /// <summary>
        /// Define o ISBN do Livro
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(13, ErrorMessage = "O {0} deve ter até {1} caracteres!")]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        /// <summary>
        /// Faz uma descrição do Livro
        /// </summary>
        [StringLength(5000, ErrorMessage = "A {0} deve ter até {1} caracteres!")]
        [Display(Name = "Sinopse")]
        public string Sinopse { get; set; }

        /// <summary>
        /// Nome do ficheiro da Imagem
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(35, ErrorMessage = "O {0} deve ter até {1} caracteres!")]
        [Display(Name = "Imagem")]
        public string Imagem { get; set; }

        /// <summary>
        /// Define o preço do Livro
        /// </summary>
        [StringLength(6, ErrorMessage = "A {0} deve ter até {1} caracteres!")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        /// <summary>
        /// Define o IVA do livro
        /// </summary>
        [Display(Name = "IVA")]
        public int IVA { get; set; }

        // ***************************************************

        // ###################################################

        // associar os Livros às Encomendas
        /// <summary>
        /// Lista de Encomendas do Livro
        /// </summary>
        public ICollection<EncomendaLivro> ListaEncomendas { get; set; }

        // associar os Livros às Encomendas
        /// <summary>
        /// Lista de Géneros do Livro
        /// </summary>
        public ICollection<Genero> ListaTemas { get; set; }
    
    }

}

