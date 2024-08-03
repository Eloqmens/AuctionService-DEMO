using FluentValidation;

namespace AuctionService.Application.Auctions.Commands.CreateAuction
{
    public class CreateAuctionCommandValidator : AbstractValidator<CreateAuctionCommand> 
    {
        public CreateAuctionCommandValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required");
            RuleFor(x => x.StartingPrice).GreaterThan(0).WithMessage("Starting price must be greater than zero");
            RuleFor(x => x.StartDate).LessThan(x => x.EndDate).WithMessage("Start date must be before end date");
        }
    }
}
