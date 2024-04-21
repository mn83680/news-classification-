using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace News_Project.Models
{
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NewsId { get; set; }

        public string NewsTitle { get; set; }

        public string NewsText { get; set; }

        public string NewsImage { get; set; }

        public Admin Admin { get; set; }

        [ForeignKey("Admine")]
        public int AdminId { get; set; }

        public Category category { get; set; }

        [ForeignKey("category")]
        public int CategoryId { get; set; }
    }
}
