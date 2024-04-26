using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace NewsClasification.Models
{
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public int Category { get; set; }

        [ForeignKey("Publisher")]
        public int pub_Id { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}