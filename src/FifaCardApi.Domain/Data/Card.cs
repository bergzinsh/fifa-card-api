namespace FifaCardApi.Domain.Data
{
    public class Card
    {
        public int Id { get; set; }
        public short Pace { get; set; }
        public short Shooting { get; set; }
        public short Passing { get; set; }
        public short Dribbling { get; set; }
        public short Defending { get; set; }
        public short Physicality { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}