using FifaCardApi.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaCardApi.Repository.Repository.Interfaces
{
    public interface ICardRepository
    {
        public Task<int> InsertNewPlayer(Player player, Card card);
    }
}
