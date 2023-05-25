using FifaCardApi.Domain.Data;
using FifaCardApi.Domain.Request;
using FifaCardApi.Service.Services.Interfaces;
using Microsoft.Extensions.Logging;
using FifaCardApi.Repository.Repository.Interfaces;
using FifaCardApi.Domain.Request.Model;

namespace FifaCardApi.Service.Services
{
    public class CardService : ICardService
    {
        private readonly ILogger<ICardService> _logger;
        private readonly ICardRepository _cardRepository;

        public CardService(ILogger<ICardService> logger, ICardRepository cardRepository)
        {
            _logger = logger;
            _cardRepository = cardRepository;
        }

        public bool MapNewPlayerCard(PlayerRequestModel request)
        {
            var player = new Player
            {
                Age = request.Age,
                Name = request.Name
            };

            var resultInsertPlayer = _cardRepository.InsertNewPlayer(player);

            var playerCard = new Card
            {
                Pace = request.Pace,
                Shooting = request.Shooting,
                Passing = request.Passing,
                Dribbling = request.Dribbling,
                Defending = request.Defending,
                Physicality = request.Physicality
            };

            var resultInsertCard = _cardRepository.InsertNewCard(playerCard, player.Id);

            return true;
        }
    }
}