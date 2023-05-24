using FifaCardApi.Domain.Data;

namespace FifaCardApi.Domain.Request
{
    public class PlayerRequest
    {
        public Card PlayerCard { get; }

        public PlayerRequest(Card playerCard)
        {
            PlayerCard = playerCard;
        }
    }
}