using System.ComponentModel.DataAnnotations;

namespace CVSite.Models
{
    public class Hobbies
    {
        [Key]
        public int ID { get; set; }
        public string Hobbie { get; set; }
    }
}
