using AuctionService.Application.Auctions.Commands.CreateAuction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.API.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class AuctionController : Controller
    {
        private readonly IMediator _mediator;
        public AuctionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAuctionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
