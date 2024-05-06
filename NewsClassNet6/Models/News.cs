using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace NewsClassNet6.Models
{
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public string image { get; set; }
            public DateTime PublishDate { get; set; }

        [ForeignKey("Category")]
        public int Category_Id { get; set; }  // Clear foreign key indication
        public virtual Category Category { get; set; }

        // Clear foreign key linkage with navigation property
        [ForeignKey("Publisher")]
        public string PublisherId { get; set; }
        public virtual ApplicationUser Publisher { get; set; }
    }
}
