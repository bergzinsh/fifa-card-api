using FifaCardApi.Domain.Data;

namespace FifaCardApi.Domain.Request
{
    public class PlayerRequest
    {
        public PlayerCard PlayerCard { get; }

        public PlayerRequest(PlayerCard playerCard)
        {
            PlayerCard = playerCard;
        }
    }
}