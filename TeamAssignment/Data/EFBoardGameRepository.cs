using System.Linq;

namespace TeamAssignment.Models
{
    public class EFBoardGameRepository : IBoardGameRepository
    {
        private ApplicationDbContext context;
        public EFBoardGameRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<BoardGame> BoardGames => context.BoardGames;

        public void SaveGame(BoardGame game)
        {
            if (game.Id == 0)
            {
                context.BoardGames.Add(game);
            }
            else
            {
                BoardGame dbEntry = context.BoardGames.FirstOrDefault(dbGame => dbGame.Id == game.Id);

                if (dbEntry != null)
                {
                    dbEntry.Name = game.Name;
                    dbEntry.Category = game.Category;
                    dbEntry.Players = game.Players;
                    dbEntry.Description = game.Description;
                    dbEntry.Publisher = game.Publisher;
                    dbEntry.ReleaseDate = game.ReleaseDate;
                    dbEntry.ImageURL = game.ImageURL;
                    dbEntry.Price = game.Price;
                    dbEntry.Quantity = game.Quantity;
                }
            }

            context.SaveChanges();
        }

        public BoardGame DeleteGame(int gameID)
        {
            BoardGame dbEntry = context.BoardGames.FirstOrDefault(dbGame => dbGame.Id == gameID);

            if (dbEntry != null)
            {
                context.BoardGames.Remove(dbEntry);
                context.SaveChanges();
            }

            return dbEntry;
        }
    }
}
