using System.ComponentModel.DataAnnotations;

namespace CVSite.Models
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }
        public string Photo { get; set; }

    }
}
