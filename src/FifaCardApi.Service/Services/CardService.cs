using FifaCardApi.Domain.Data;
using FifaCardApi.Domain.Request;
using FifaCardApi.Service.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace FifaCardApi.Service.Services
{
    public class CardService : ICardService
    {
        private readonly ILogger<ICardService> _logger;

        public CardService(ILogger<ICardService> logger)
        {
            _logger = logger;
        }

        public Card ReturnPlayerCard(PlayerRequest request)
        {
            return new Card()
            {
                Pace = request.PlayerCard.Pace,
                Shooting = request.PlayerCard.Shooting,
                Passing = request.PlayerCard.Passing,
                Dribbling = request.PlayerCard.Dribbling,
                Defending = request.PlayerCard.Defending,
                Physicality = request.PlayerCard.Physicality,
            };
        }
    }
}