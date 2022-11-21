using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChristmasBasketGift.Data;
using ChristmasBasketGift.Models;

namespace ChristmasBasketGift.Pages
{
    public class OrdersModel : PageModel
    {
        public List<GiftOrder> GiftOrders = new List<GiftOrder>();
        private readonly ApplicationBdContext _Context;
        public OrdersModel(ApplicationBdContext context)
        {
            _Context = context;
        }
        public void OnGet()
        {
            GiftOrders = _Context.GiftOrders.ToList();
        }
    }
}
