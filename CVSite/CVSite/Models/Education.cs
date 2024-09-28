using System.ComponentModel.DataAnnotations;

namespace CVSite.Models
{
    public class Education
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string GNote { get; set; }
        public string Date { get; set; }
    }
}
