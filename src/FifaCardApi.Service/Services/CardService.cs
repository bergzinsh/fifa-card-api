using FifaCardApi.Domain.Data;
using FifaCardApi.Domain.Request;
using FifaCardApi.Service.Services.Interfaces;
using Microsoft.Extensions.Logging;
using FifaCardApi.Repository.Repository.Interfaces;

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
    }
}