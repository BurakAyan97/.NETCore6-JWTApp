namespace UdemyJwtApp.Back.Core.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Definition { get; set; }

        //Nav Props
        public List<Product>? Products { get; set; }
       
    }
}
