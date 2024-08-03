using AuctionService.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionService.Application.Auctions.Queries
{
    public class GetAuctionsQuery : IRequest<List<Auction>>
    {
    }
}
