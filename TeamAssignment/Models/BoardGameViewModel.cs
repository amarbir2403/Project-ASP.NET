using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamAssignment.Models
{
    public class BoardGameViewModel
    {
        public List<BoardGame> BoardGames { get; set; }

        public int Pages { get { return BoardGames.Count / 3 + 1; } }
    }
}
