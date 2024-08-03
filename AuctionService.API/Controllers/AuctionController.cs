using AuctionService.Application.Auctions.Commands.CreateAuction;
using AuctionService.Application.Auctions.Queries;
using AuctionService.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.API.Controllers
{
    namespace AuctionService.API.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class AuctionsController : ControllerBase
        {
            private readonly IMediator _mediator;

            public AuctionsController(IMediator mediator)
            {
                _mediator = mediator;
            }

            [HttpPost]
            public async Task<IActionResult> Create(CreateAuctionCommand command)
            {
                var auctionId = await _mediator.Send(command);
                return Ok(auctionId);
            }

            [HttpGet]
            public async Task<ActionResult<List<Auction>>> GetAll()
            {
                var auctions = await _mediator.Send(new GetAuctionsQuery());
                return Ok(auctions);
            }
        }
    }

}
