namespace Front_to_back_Flowers.Models
{
    public class Flower:BaseClass
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public List<FlowerImg>? FlowerImg { get; set; }
    }
}
