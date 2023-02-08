namespace StaycationDemo.Models
{
    public class Suite
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Location { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool IsBooked { get; set; }
        public bool IsMostPicked { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }


    }
}
