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

        public async Task<int> InsertNewPlayer(Player player, Card card)
        {
            _playerContext.Player.Add(player);
            _playerContext.Cards.Add(card);
            var result = await _playerContext.SaveChangesAsync();

            return result;
        }
    }
}