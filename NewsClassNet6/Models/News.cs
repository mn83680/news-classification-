using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
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

        public string image {  get; set; }

        public DateTime PublishDate { get; set; }

        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Publisher")]
        public int pub_Id { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}