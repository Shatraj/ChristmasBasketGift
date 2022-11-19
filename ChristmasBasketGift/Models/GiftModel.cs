namespace ChristmasBasketGift.Models
{
    public class GiftModel
    {
        public string ImageTitle { get; set; }
        public string Name { get; set; }

        public float BasePrice { get; set; } = 10;
        public bool WhiteWine { get; set; } 
        public bool RedWine { get; set;  }
        public bool WhiteChocolate { get; set; }
        public bool DarkChocolate { get; set;  }
        public bool Bonbons { get; set; }
        public bool Snacks { get; set; }
        public bool WineGlass { get; set; }
        public bool Panettone { get; set; }
        public bool Sweets { get; set; }
        public bool MixedNuts { get; set; }
        public bool GoldPear { get; set; }
        public bool Cheese { get; set; }
        public bool Ham { get; set; }
        public bool DriedFruit { get; set; }
        public bool Cookies { get; set; }
        public bool Cake { get; set; }
        public bool MixSmallChocolate { get; set; }
        public float FinalPrice { get; set; }
    }
}
