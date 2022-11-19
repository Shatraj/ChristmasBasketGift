using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChristmasBasketGift.Models;

namespace ChristmasBasketGift.Pages.Form
{
    public class CustomModel : PageModel
    {
        [BindProperty]
        public GiftModel Gift { get; set; }
        public float GiftPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            GiftPrice = Gift.BasePrice;

            if (Gift.WhiteWine) GiftPrice += 10;
            if (Gift.RedWine) GiftPrice += 12;
            if (Gift.WhiteChocolate) GiftPrice += 7;
            if (Gift.DarkChocolate) GiftPrice += 7;
            if (Gift.Bonbons) GiftPrice += 6;
            if (Gift.Snacks) GiftPrice += 20;
            if (Gift.WineGlass) GiftPrice += 25;
            if (Gift.Panettone) GiftPrice += 15;
            if (Gift.Sweets) GiftPrice += 20;
            if (Gift.MixedNuts) GiftPrice += 24;
            if (Gift.GoldPear) GiftPrice += 4;
            if (Gift.Cheese) GiftPrice += 8;
            if (Gift.Ham) GiftPrice += 8;
            if (Gift.DriedFruit) GiftPrice += 12;
            if (Gift.Cake) GiftPrice += 6;
            if (Gift.Cookies) GiftPrice += 8;
            if (Gift.MixSmallChocolate) GiftPrice += 10;

            return RedirectToPage("/Checkout/Checkout", new { Gift.Name, GiftPrice });
            
        }
    }
}
