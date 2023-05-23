using FifaCardApi.Domain.Request;
using FluentValidation;

namespace FifaCardApi.Service.Validators
{
    public class PlayerRequestValidator : AbstractValidator<PlayerRequest>
    {
        private readonly string _errorMessage = "{0} parameter is invalid. {1}";
        public PlayerRequestValidator()
        {
            RuleFor(x => x.PlayerCard.Pace)
                .Must(pace 
                => 0 < pace
                && pace < 100)
                .WithMessage((p, a) 
                    => string.Format(_errorMessage, nameof(p.PlayerCard.Pace), p.PlayerCard.Pace.ToString()));
            
            RuleFor(x => x.PlayerCard.Shooting)
                .Must(shooting 
                    => 0 < shooting
                       && shooting < 100)
                .WithMessage((p, a) 
                    => string.Format(_errorMessage, nameof(p.PlayerCard.Shooting), p.PlayerCard.Shooting.ToString()));
            
            RuleFor(x => x.PlayerCard.Passing)
                .Must(passing 
                    => 0 < passing
                       && passing < 100)
                .WithMessage((p, pace) 
                    => string.Format(_errorMessage, nameof(p.PlayerCard.Passing), p.PlayerCard.Passing.ToString()));
            
            RuleFor(x => x.PlayerCard.Dribbling)
                .Must(dribbling 
                    => 0 < dribbling
                       && dribbling < 100)
                .WithMessage((p, pace) 
                    => string.Format(_errorMessage, nameof(p.PlayerCard.Dribbling), p.PlayerCard.Dribbling.ToString()));
            
            RuleFor(x => x.PlayerCard.Defending)
                .Must(defending 
                    => 0 < defending
                       && defending < 100)
                .WithMessage((p, pace) 
                    => string.Format(_errorMessage, nameof(p.PlayerCard.Defending), p.PlayerCard.Defending.ToString()));
            
            RuleFor(x => x.PlayerCard.Physicality)
                .Must(physicality 
                    => 0 < physicality
                       && physicality < 100)
                .WithMessage((p, pace) 
                    => string.Format(_errorMessage, nameof(p.PlayerCard.Physicality), p.PlayerCard.Physicality.ToString()));
        }
    }
}