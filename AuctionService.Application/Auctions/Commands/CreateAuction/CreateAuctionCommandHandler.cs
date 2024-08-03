using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionService.Domain.Entities;
using AuctionService.Infrastructure.Data;
using MediatR;
namespace AuctionService.Application.Auctions.Commands.CreateAuction
{
    public class CreateAuctionCommandHandler : IRequestHandler<CreateAuctionCommand, int>
    {
        private readonly AuctionDbContext _context;

        public CreateAuctionCommandHandler(AuctionDbContext context)
        {

            _context = context; 

        }

        public async Task<int> Handle(CreateAuctionCommand request, CancellationToken cancellationToken)
        {
            var auction = new Auction
            {
                Title = request.Title,
                StartingPrice = request.StartingPrice,
                StartDate = request.StartDate,
                EndDate = request.EndDate
            };

            _context.Auctions.Add(auction);
            await _context.SaveChangesAsync(cancellationToken);

            return auction.Id;
        }
    }
}
