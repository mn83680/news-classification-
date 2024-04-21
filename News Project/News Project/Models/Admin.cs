using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace News_Project.Models
{
    public class Admin
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminId { get; set; }
      
        public string AdminName { get; set; }
     
        public string AdminEmail { get; set; }

        public string AdminPassword { get; set; }


        /*
        public virtual List<News> NewsOfAnmin { get; set; }

        public void AddNews(News news)
        {
            News.Add(news);
        }
        public void RemoveNews(News news)
        {
            News.Remove(news);
        }
        */
    }
}
