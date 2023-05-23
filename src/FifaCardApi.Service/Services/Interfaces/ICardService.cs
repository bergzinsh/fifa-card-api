using System.Threading.Tasks;
using FifaCardApi.Domain.Data;
using FifaCardApi.Domain.Request;

namespace FifaCardApi.Service
{
    public interface ICardService
    {
        PlayerCard ReturnPlayerCard(PlayerRequest request);
    }
}