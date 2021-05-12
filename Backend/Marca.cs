using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Backend
{
    public class Marca
    {
        //MAPEAMENTO UTILIZANDO FLUENT-API
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdPais { get; set; }
        public virtual Pais Pais { get; set; }

    }
}
