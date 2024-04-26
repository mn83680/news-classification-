using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NewsClasification.Models
{
    public class StoreNews
    {
       

        [ForeignKey("Publisher")]
        public int pub_Id { get; set; }
        public Publisher publisher;

        [ForeignKey("News")]
        public int pub { get; set; }
        public News news;
    }
}
