using System.ComponentModel.DataAnnotations;

namespace CVSite.Models
{
    public class Skills
    {
        [Key]
        public int ID { get; set; }

        public string Skill { get; set; }
    }
}
