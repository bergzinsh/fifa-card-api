using FifaCardApi.Domain.Context;
using FifaCardApi.Domain.Data;
using FifaCardApi.Repository.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FifaCardApi.Repository.Repository
{
    public class CardRepository : ICardRepository
    {
        private readonly ILogger<ICardRepository> _logger;
        private readonly PlayerContext _playerContext;
        public CardRepository(ILogger<ICardRepository> logger, PlayerContext playerContext, IConfiguration configuration)
        {
            _logger = logger;
            _playerContext = playerContext;
        }

        public bool InsertNewPlayer(Player player)
        {
            _playerContext.Player.Add(player);
            var resultPlayer = _playerContext.SaveChanges();

            return true;
        }

        public bool InsertNewCard(Card card, Guid playerId)
        {
            card.PlayerId = playerId;
            _playerContext.Cards.Add(card);
            var resultCard = _playerContext.SaveChanges();

            return true;
        }
    }
}