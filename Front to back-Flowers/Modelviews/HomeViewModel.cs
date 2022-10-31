using Front_to_back_Flowers.Models;

namespace Front_to_back_Flowers.Modelviews
{
    public class HomeViewModel
    {
        public List<Flower> Flowers { get; set; } = new List<Flower>();
        public List<FlowerExpert> FlowerExperts { get; set; }=new List<FlowerExpert>();
        public List<FlowerImg> FlowerImgs { get; set; } = new List<FlowerImg>();
        public List<MarketingSlider> MarketingSliders { get; set; } = new List<MarketingSlider>();
        public List<SliderIndex> SliderIndexs { get; set; } = new List<SliderIndex>();
    }
}
