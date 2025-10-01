using auction_app.Entities;
using Microsoft.EntityFrameworkCore;

namespace auction_app.Data;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Auction>  Auctions {get; set;}
}