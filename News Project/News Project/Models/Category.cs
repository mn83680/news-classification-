namespace News_Project.Models
{
    public class Category
    {
        public Category() { }
        public Category(int id,string name) {
        this.CategoryName = name;
        this.CategoryId = id;
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

}