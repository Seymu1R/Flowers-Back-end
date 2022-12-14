namespace Front_to_back_Flowers.Models
{
    public class Flower:BaseClass
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int FlowerCategoryId { get; set; }
        public FlowerCategory? FlowerCategory { get; set; } = new FlowerCategory();
        public List<FlowerImg>? FlowerImg { get; set; }
    }
}
