using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChristmasBasketGift.Models;

namespace ChristmasBasketGift.Pages
{
    public class GiftsModel : PageModel
    {
        public List<GiftModel> fakeDbGift = new List<GiftModel>()
        {
            new GiftModel()
            {
                ImageTitle="Banquet Gift With Wine",
                Name="Banquet Gift With Wine",
                BasePrice=10,
                GoldPear=true,
                WhiteWine=true,
                MixedNuts=true,
                MixSmallChocolate=true,
                Cookies=true,
                FinalPrice=62
            },

             new GiftModel()
            {
                ImageTitle="WineDuo",
                Name="Wine Duo",
                BasePrice=10,
               WhiteWine=true,
               RedWine=true,
               FinalPrice=22
            },

              new GiftModel()
            {
                ImageTitle="PearGoldWithWine",
                Name="Pear Gold With Wine",
                BasePrice=10,
                GoldPear=true,
                WhiteWine=true,
                FinalPrice=20
               
            },

               new GiftModel()
            {
                ImageTitle="DeluxBanquetGiftWithWine",
                Name="Banquet Gift With Wine",
                BasePrice=10,
                GoldPear=true,
                WhiteWine=true,
                MixedNuts=true,
                MixSmallChocolate=true,
                Cookies=true,
                RedWine=true,
                Snacks=true,
                DriedFruit=true,
                FinalPrice=64
                   

                   
            },

                new GiftModel()
            {
                ImageTitle="ElfPantsWineGift",
                Name="Elf Pants Wine Gift",
                BasePrice=10,
                RedWine=true,
                WhiteWine=true,
                Bonbons=true,
                FinalPrice=42
                    
            },

                 new GiftModel()
            {
                ImageTitle="SweetandSavoryGiftWithWine",
                Name="Sweet and Savory Gift With Wine",
                BasePrice=10,
                GoldPear=true,
                WhiteWine=true,
                MixedNuts=true,
                MixSmallChocolate=true,
                Cookies=true,
                Ham=true,
                Cheese=true,
                DriedFruit=true,
                FinalPrice=68
                     
            },
        };
        public void OnGet()
        {
        }
    }
}
