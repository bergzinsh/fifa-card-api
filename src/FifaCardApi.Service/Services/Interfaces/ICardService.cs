using System.Threading.Tasks;
using FifaCardApi.Domain.Request;
using FifaCardApi.Domain.Data;

namespace FifaCardApi.Service.Services.Interfaces
{
    public interface ICardService
    {
        PlayerCard ReturnPlayerCard(PlayerRequest request);
    }
}