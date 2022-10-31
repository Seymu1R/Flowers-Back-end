namespace Front_to_back_Flowers.Models
{
    public class FlowerImg:BaseClass
    {
        public string? ImgPath { get; set; }
        public int FlowerId { get; set; }
        public Flower? Flower { get; set; }
    }
}
