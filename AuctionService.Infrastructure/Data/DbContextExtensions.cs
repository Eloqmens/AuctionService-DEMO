using AuctionService.Domain.Entities;

namespace AuctionService.Infrastructure.Data
{
    public static class DbContextExtensions
    {
        public static void Seed(this AuctionDbContext context)
        {
            if (!context.Auctions.Any())
            {
                context.Auctions.AddRange(
                    new Auction { Title = "Auction 1", StartingPrice = 100, StartDate = DateTime.Now.AddDays(1), EndDate = DateTime.Now.AddDays(10) },
                    new Auction { Title = "Auction 2", StartingPrice = 200, StartDate = DateTime.Now.AddDays(2), EndDate = DateTime.Now.AddDays(11) },
                    new Auction { Title = "Auction 3", StartingPrice = 300, StartDate = DateTime.Now.AddDays(3), EndDate = DateTime.Now.AddDays(12) },
                    new Auction { Title = "Auction 4", StartingPrice = 400, StartDate = DateTime.Now.AddDays(4), EndDate = DateTime.Now.AddDays(13) },
                    new Auction { Title = "Auction 5", StartingPrice = 500, StartDate = DateTime.Now.AddDays(5), EndDate = DateTime.Now.AddDays(14) },
                    new Auction { Title = "Auction 6", StartingPrice = 600, StartDate = DateTime.Now.AddDays(6), EndDate = DateTime.Now.AddDays(15) },
                    new Auction { Title = "Auction 7", StartingPrice = 700, StartDate = DateTime.Now.AddDays(7), EndDate = DateTime.Now.AddDays(16) },
                    new Auction { Title = "Auction 8", StartingPrice = 800, StartDate = DateTime.Now.AddDays(8), EndDate = DateTime.Now.AddDays(17) },
                    new Auction { Title = "Auction 9", StartingPrice = 900, StartDate = DateTime.Now.AddDays(9), EndDate = DateTime.Now.AddDays(18) },
                    new Auction { Title = "Auction 10", StartingPrice = 1000, StartDate = DateTime.Now.AddDays(10), EndDate = DateTime.Now.AddDays(19) },
                    new Auction { Title = "Auction 11", StartingPrice = 1100, StartDate = DateTime.Now.AddDays(11), EndDate = DateTime.Now.AddDays(20) },
                    new Auction { Title = "Auction 12", StartingPrice = 1200, StartDate = DateTime.Now.AddDays(12), EndDate = DateTime.Now.AddDays(21) },
                    new Auction { Title = "Auction 13", StartingPrice = 1300, StartDate = DateTime.Now.AddDays(13), EndDate = DateTime.Now.AddDays(22) },
                    new Auction { Title = "Auction 14", StartingPrice = 1400, StartDate = DateTime.Now.AddDays(14), EndDate = DateTime.Now.AddDays(23) },
                    new Auction { Title = "Auction 15", StartingPrice = 1500, StartDate = DateTime.Now.AddDays(15), EndDate = DateTime.Now.AddDays(24) }
                );

                context.SaveChanges();
            }
        }
    }
}
