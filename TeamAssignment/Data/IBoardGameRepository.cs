using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamAssignment.Models
{
    public interface IBoardGameRepository
    {
        IQueryable<BoardGame> BoardGames { get; }
        void SaveGame(BoardGame board);
        BoardGame DeleteGame(int gameID);
    }
}
