using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLounge.Models
{
    /// <summary>
    /// Encomenda efectuada na aplicação
    /// </summary>
    public class Encomenda
    {

        public Encomenda()
        {
            // Inicializar a lista de Livros de cada uma das Encomendas
            ListaLivros = new HashSet<EncomendaLivro>();
        }

        /// <summary>
        /// Identificador de cada um das Encomendas
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Regista a data de encomenda
        /// </summary>
        [Display(Name = "Data Encomenda")]
        public DateTime DataEncomenda { get; set; }

        /// <summary>
        /// Regista a data de envio
        /// </summary>
        [Display(Name = "Data Envio")]
        public DateTime DataEnvio { get; set; }

        /// <summary>
        /// Define o IVA total da encomenda
        /// </summary>
        [Display(Name = "IVA Encomenda")]
        public int IvaEncomenda { get; set; }


        /// <summary>
        /// Define o estado da encomenda
        /// </summary>
        [Display(Name = "Estado da Encomenda")]
        public bool Estado { get; set; }


        // ***************************************************

        /// <summary>
        /// FK para o Utilizador criador da Encomenda
        /// </summary>
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadorFK { get; set; }
        public Utilizador Utilizador { get; set; }

        // ###################################################

        // associar os Monumentos às Caraterísticas
        /// <summary>
        /// Lista de Livros da Encomenda
        /// </summary>
        public ICollection<EncomendaLivro> ListaLivros { get; set; }
    }

}
