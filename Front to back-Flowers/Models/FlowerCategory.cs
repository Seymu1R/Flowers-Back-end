namespace Front_to_back_Flowers.Models
{
    public class FlowerCategory:BaseClass
    {
        public string? Name { get; set; }
        List<Flower>? Flowers { get; set; }
    }
}
