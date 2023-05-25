using FifaCardApi.Domain.Request.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaCardApi.Domain.Request
{
    public class PlayerCreationRequest
    {
        [JsonPropertyName("playerCard")]
        public PlayerRequestModel CardAttributes { get; set; }
    }
}
