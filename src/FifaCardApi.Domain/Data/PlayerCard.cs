using FifaCardApi.Domain.Data.Abstract;

namespace FifaCardApi.Domain.Data
{
    public class PlayerCard : Player
    {
        public short Pace { get; set; }
        public short Shooting { get; set; }
        public short Passing { get; set; }
        public short Dribbling { get; set; }
        public short Defending { get; set; }
        public short Physicality { get; set; }
    }
}