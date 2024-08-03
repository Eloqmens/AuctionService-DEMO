using AuctionService.Domain.Entities;
using AuctionService.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Application.Auctions.Queries
{
    public class GetAuctionsQueryHandler : IRequestHandler<GetAuctionsQuery, List<Auction>>
    {
        private readonly AuctionDbContext _context;

        public GetAuctionsQueryHandler(AuctionDbContext context)
        {
            _context = context;
        }

        public async Task<List<Auction>> Handle(GetAuctionsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Auctions.ToListAsync(cancellationToken);
        }
    }
}
