namespace E_Commerce_B_W2_Project.Models
{
    public class ProductBaseModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public List<ImgSrc> ImgListModel { get; set; } = new List<ImgSrc>();
        public int Comment { get; set; }
        public int Sales { get; set; }

        public int IntPrice { get; set; }
        public int IntCents { get; set; }
        public string? Consegna { get; set; }
    }
}
