using Microsoft.EntityFrameworkCore;
using ChristmasBasketGift.Models;
namespace ChristmasBasketGift.Data
{
    public class ApplicationBdContext : DbContext
    {
        public DbSet<GiftOrder> GiftOrders { get; set; }
        public ApplicationBdContext (DbContextOptions<ApplicationBdContext> options) 
            : base(options)
           
        {

        }
    }
    
   
}
