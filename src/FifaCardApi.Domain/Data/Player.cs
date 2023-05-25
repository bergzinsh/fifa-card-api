namespace FifaCardApi.Domain.Data
{
    public class Player
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public short Age { get; set; }
        public IEnumerable<Card>? Cards { get; set; }

    }
}