using FifaCardApi.Domain.Request;
using FifaCardApi.Domain.Request.Model;
using FluentValidation;

namespace FifaCardApi.Service.Validators
{
    public class PlayerRequestValidator : AbstractValidator<PlayerRequestModel>
    {
        private readonly string _errorMessage = "{0} parameter is invalid. {1}";
        public PlayerRequestValidator()
        {
            RuleFor(x => x.Pace)
                .Must(pace
                => 0 < pace
                && pace < 100)
                .WithMessage((p, a)
                    => string.Format(_errorMessage, nameof(p.Pace), p.Pace.ToString()));

            RuleFor(x => x.Shooting)
                .Must(shooting
                    => 0 < shooting
                       && shooting < 100)
                .WithMessage((p, a)
                    => string.Format(_errorMessage, nameof(p.Shooting), p.Shooting.ToString()));

            RuleFor(x => x.Passing)
                .Must(passing
                    => 0 < passing
                       && passing < 100)
                .WithMessage((p, pace)
                    => string.Format(_errorMessage, nameof(p.Passing), p.Passing.ToString()));

            RuleFor(x => x.Dribbling)
                .Must(dribbling
                    => 0 < dribbling
                       && dribbling < 100)
                .WithMessage((p, pace)
                    => string.Format(_errorMessage, nameof(p.Dribbling), p.Dribbling.ToString()));

            RuleFor(x => x.Defending)
                .Must(defending
                    => 0 < defending
                       && defending < 100)
                .WithMessage((p, pace)
                    => string.Format(_errorMessage, nameof(p.Defending), p.Defending.ToString()));

            RuleFor(x => x.Physicality)
                .Must(physicality
                    => 0 < physicality
                       && physicality < 100)
                .WithMessage((p, pace)
                    => string.Format(_errorMessage, nameof(p.Physicality), p.Physicality.ToString()));
        }
    }
}