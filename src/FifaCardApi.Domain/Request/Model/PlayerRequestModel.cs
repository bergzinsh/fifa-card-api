using FifaCardApi.Domain.Data;
using System.Text.Json.Serialization;

namespace FifaCardApi.Domain.Request.Model
{
    public class PlayerRequestModel
    {
        public string? Name { get; set; }
        public short Age { get; set; }
        public short Pace { get; set; }
        public short Shooting { get; set; }
        public short Passing { get; set; }
        public short Dribbling { get; set; }
        public short Defending { get; set; }
        public short Physicality { get; set; }
    }
}