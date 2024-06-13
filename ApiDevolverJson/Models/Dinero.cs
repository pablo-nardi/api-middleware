using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiDevolverJson.Models
{
    public class Dinero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime Fecha { get; set; }
        public string Cuenta { get; set; }
        public string Categoria { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
    }
}
