using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChristmasBasketGift.Data;
using ChristmasBasketGift.Models;

namespace ChristmasBasketGift.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string Name { get; set; }
        public float GiftPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationBdContext _Context;
        public CheckoutModel(ApplicationBdContext context)
        {
            _Context = context;

        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "Custom";
            }

            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "pako1";
            }

            GiftOrder giftOrder = new GiftOrder();
           
            giftOrder.Name = Name;
            giftOrder.BasePrice = GiftPrice;

            _Context.GiftOrders.Add(giftOrder);
            _Context.SaveChanges();
        }
    }
}
