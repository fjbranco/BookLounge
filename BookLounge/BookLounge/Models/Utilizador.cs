using System.ComponentModel.DataAnnotations;

namespace BookLounge.Models
{
    /// <summary>
    /// Utilizador registado na aplicação
    /// </summary>
    public class Utilizador
    {

        public Utilizador()
        {
            ListaEncomendas = new HashSet<Encomenda>();
            
        }

        /// <summary>
        /// Identificador de cada um dos Utilizadores
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Define o Login do Utilizador 
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(15, ErrorMessage = "O {0} não pode ter mais de {1} caracteres!")]
        [RegularExpression("[a-z]")]
        public string Login { get; set; }

        /// <summary>
        /// Define a Password do Utilizador
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(25, MinimumLength = 8, ErrorMessage = "O {0} deve ter {2} até {1} caracteres!")]
        public string Password { get; set; }

        /// <summary>
        /// Identifica o Nome do Utilizador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(60, ErrorMessage = "O {0} não pode ter mais de {1} caracteres!")]
        [RegularExpression("([A-ZÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÄËÏÖÜÃÕÇÑa-záéíóúàèìòùâêîôûäëïöüãõçñ '-]+)+")]
        public string Nome { get; set; }

        /// <summary>
        /// Define o Email do Utilizador
        /// </summary>
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres!")]
        [EmailAddress(ErrorMessage = "O {0} não é válido!")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }


        /// <summary>
        /// Identifica a Morada do Utilizador
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(60, ErrorMessage = "O {0} não pode ter mais de {1} caracteres!")]
        [RegularExpression("([A-ZÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÄËÏÖÜÃÕÇÑa-záéíóúàèìòùâêîôûäëïöüãõçñ '-]+)+")]
        [Display(Name = "Morada")]
        public string Morada { get; set; }

        /// <summary>
        /// Identifica o Código Postal do Utilizador
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(8, ErrorMessage = "O {0} não pode ter mais de {1} caracteres!")]
        [RegularExpression("[0-9]{4}-[0-9]{3}")]
        [Display(Name = "Código Postal")]
        public string CodPostal { get; set; }

        /// <summary>
        /// Identifica o Telemóvel do Utilizador
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(9, ErrorMessage = "O {0} não pode ter mais de {1} caracteres!")]
        [RegularExpression("0-9")]
        [Display(Name = "Telemóvel")]
        public string Telemovel { get; set; }

        /// <summary>
        /// Identifica o número de contribuinte do Utilizador
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")] // Preenchimento obrigatório
        [StringLength(9, ErrorMessage = "O {0} não pode ter mais de {1} caracteres!")]
        [RegularExpression("0-9")]
        [Display(Name = "Número de Contribuinte")]
        public string NIF { get; set; }

        // ###################################################

        /// <summary>
        /// Lista de Encomendas criadas pelo utilizador
        /// </summary>
        public ICollection<Encomenda> ListaEncomendas { get; set; }

        
    }

}
