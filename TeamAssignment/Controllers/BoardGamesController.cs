using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamAssignment.Models;

namespace TeamAssignment.Controllers
{
    public class BoardGamesController : Controller
    {
        private IBoardGameRepository repository;
        public BoardGamesController(IBoardGameRepository repo)
        {
            repository = repo;
        }
        
        // GET: BoardGames
        public IActionResult Index() => View(new BoardGameViewModel { BoardGames = repository.BoardGames.ToList() });

        // GET: BoardGames/List
        public IActionResult List() => View(new BoardGameViewModel { BoardGames = repository.BoardGames.ToList() });

        // GET: BoardGames/AdminList
        public IActionResult AdminList() => View(new BoardGameViewModel { BoardGames = repository.BoardGames.ToList() });

        // GET: BoardGames/Item/Id
        public IActionResult Item(int Id) => View(repository.BoardGames.FirstOrDefault(bg => bg.Id == Id));
        
        // GET: BoardGames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BoardGames/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BoardGame boardGame)
        {
            if (ModelState.IsValid)
            {
                repository.SaveGame(boardGame);
                return RedirectToAction("AdminList");
            }

            return View(boardGame);
        }

        // GET: BoardGames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boardGame = await repository.BoardGames.FirstOrDefaultAsync(dbGame => dbGame.Id == id);
            if (boardGame == null)
            {
                return NotFound();
            }
            return View(boardGame);
        }

        // POST: BoardGames/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, BoardGame boardGame)
        {
            if (id != boardGame.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                repository.SaveGame(boardGame);
                return RedirectToAction("AdminList");
            }
            return View(boardGame);
        }
        
        // GET: BoardGames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boardGame = await repository.BoardGames.FirstOrDefaultAsync(bg => bg.Id == id);
            if (boardGame == null)
            {
                return NotFound();
            }

            return View(boardGame);
        }

        // POST: BoardGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            BoardGame deletedGame = repository.DeleteGame(id);

            return RedirectToAction("AdminList");
        }
    }
}
