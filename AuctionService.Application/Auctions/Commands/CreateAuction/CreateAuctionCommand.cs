using MediatR;

namespace AuctionService.Application.Auctions.Commands.CreateAuction
{
    public class CreateAuctionCommand : IRequest<int>
    {
        public string Title { get; set; }
        public decimal StartingPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
