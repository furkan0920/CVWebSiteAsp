using System.ComponentModel.DataAnnotations;

namespace CVSite.Models
{
    public class Conferance
    {
        [Key]           
        public int ID { get; set; }

        public string Conferances { get; set; }

    }
}
