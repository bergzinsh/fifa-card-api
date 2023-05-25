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
        public bool InsertNewPlayer(Player player);
        public bool InsertNewCard (Card card, Guid playerId);
    }
}
