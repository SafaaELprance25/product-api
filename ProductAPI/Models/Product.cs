namespace ProductAPI.Models
{
    public class Product
    {
        //////////////////    public int Id { get; set; }
        //////////////////    public string NameAr { get; set; }
        //////////////////    public string NameEn { get; set; }
        //////////////////    public string ImageUrl { get; set; }
        //////////////////    public string Description { get; set; }
        //////////////////    public string Category { get; set; }
        //////////////////    public decimal Price { get; set; }
        //////////////////    public decimal Discount { get; set; }
        //////////////////}
        /// 
    public int Id { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } 
        public IFormFile Image { get; set; }
        public decimal Discount { get; set; }
     
        public string? Notes { get; set; }
      
        public int CategoryId { get; set; }
    }
}