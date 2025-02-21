namespace E_Commerce_B_W2_Project.Models
{
    public class ProductAddModel
    {
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public List<string> ImgListModel { get; set; } = new List<string>();
    }
}
