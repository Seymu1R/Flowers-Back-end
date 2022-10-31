using Front_to_back_Flowers.Models;

namespace Front_to_back_Flowers.Modelviews
{
    public class HomeViewModel
    {
        public List<Flower> Flowers { get; set; } = new List<Flower>();
        public List<FlowerExpert> FlowerExperts { get; set; }=new List<FlowerExpert>();
        public List<FlowerImg> FlowerImgs { get; set; } = new List<FlowerImg>();
        public List<MarketingSlider> MarketingSliders { get; set; } = new List<MarketingSlider>();
        public SliderIndex SliderIndex { get; set; } = new SliderIndex();
        public List<FlowerCategory> FlowerCategories { get; set; } = new List<FlowerCategory>();
        public List<SliderImage> SliderImages { get; set; }
    }
}
