using System.Threading.Tasks;
using FifaCardApi.Domain.Request;
using FifaCardApi.Domain.Data;
using FifaCardApi.Domain.Request.Model;

namespace FifaCardApi.Service.Services.Interfaces
{
    public interface ICardService
    {
        public bool MapNewPlayerCard(PlayerRequestModel request);
    }
}