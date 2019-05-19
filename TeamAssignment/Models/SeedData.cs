using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamAssignment.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {

            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.BoardGames.Any())
            {
                context.BoardGames.AddRange(
                    new BoardGame
                    {
                        Name = "Monopoly",
                        Category = "Economic",
                        Players = 4,
                        Description = "Monopoly is a board game in which players roll two six-sided dice to move around the game board, buying and trading properties, and developing them with houses and hotels. Players collect rent from their opponents, with the goal being to drive them into bankruptcy. Money can also be gained or lost through Chance and Community Chest cards, and tax squares; players can end up in jail, which they cannot move from until they have met one of several conditions.",
                        Publisher = "Hasbro",
                        ReleaseDate = DateTime.Parse("February 6, 1935"),
                        ImageURL = "https://cf.geekdo-images.com/imagepage/img/7lStFvz0a8qEc1VG9Bbcopp9mBo=/fit-in/900x600/filters:no_upscale()/pic265476.jpg",
                        Price = 49.99,
                        Quantity = 10
                    },
                    new BoardGame
                    {
                        Name = "Catan Histories: Rise of the Inkas",
                        Category = "Strategy",
                        Players = 4,
                        Description = "Long before the Inkan (aka 'Incan') Empire rose to dominance in Peru, many advanced indigenous cultures developed and declined in the Andean regions of South America. Catan: Rise of the Inkas confronts you with new strategic challenges as you play. Development works in much the same as the core mechanics of Catan build roads and settlements, gain development cards to give you an advantage, and use the robber to hinder your opponents. However, eventually your early tribe will reach their pinnacle and be supplanted as you start a new era. As you play Rise of the Inkas, you must twice decline your early tribes to make way for a new tribe's era. You remove all your constructed roads from the board and cover your settlements in vines to denote that these may no longer be developed. But your game doesn't end there. When your tribe goes into decline, you place a new settlement on an available board space and continue the game using this new settlement. Timing is an important part of your strategy as you play Catan: Rise of the Inkas, take advantage of your opponent's settlements in decline to set yourself up to claim victory.",
                        Publisher = "Asmodee Editions",
                        ReleaseDate = DateTime.Parse("November 14, 2018"),
                        ImageURL = "https://res.cloudinary.com/csicdn/image/upload/c_pad,f_auto,fl_lossy,h_350,q_auto,w_350/v1/Images/Products/Misc%20Art/Catan%20Studio/full/ASMCN3205a.jpg",
                        Price = 39.99,
                        Quantity = 10
                    },
                    new BoardGame
                    {
                        Name = "Codenames: Pictures",
                        Category = "Party",
                        Players = 8,
                        Description = "Codenames can now be played with Pictures! Whimsical, mind-twisting illustrations are used instead of word cards. Can you find one word that ties your team's pictures together?",
                        Publisher = "Czech Games Edition",
                        ReleaseDate = DateTime.Parse("January 14, 2018"),
                        ImageURL = "https://res.cloudinary.com/csicdn/image/upload/c_pad,f_auto,fl_lossy,h_350,q_auto,w_350/v1/Images/Products/Misc%20Art/Czech%20Games%20Edition/full/CODENAMESPICTURES.jpg",
                        Price = 29.99,
                        Quantity = 5
                    },
                    new BoardGame
                    {
                        Name = "Battleship",
                        Category = "War",
                        Players = 2,
                        Description = "Battleship was originally a pencil-and-paper public domain game known by different names, but Milton Bradley made it into the well known board game in 1967. The pencil and paper grids were changed to plastic grids with holes that could hold plastic pegs used to record the guesses.",
                        Publisher = "Hasbro",
                        ReleaseDate = DateTime.Parse("February 14, 1943 "),
                        ImageURL = "https://smedia.webcollage.net/rwvfp/wc/cp/1529918982535_205a4869-a329-474f-8013-397c1cf17c6d/module/hasbrous/_cp/products/1361206404563/tab-c021f305-befc-4692-b6b6-c43111b69a00/b776bb7c-70be-4890-9a01-0337d73fc389.jpg.w1920.jpg",
                        Price = 45.99,
                        Quantity = 5
                    },
                    new BoardGame
                    {
                        Name = "Trade on the Tigris",
                        Category = "RTS",
                        Players = 2,
                        Description = "The Tigris river winds through the cradle of civilization, providing food, water, and a means of transportation for trade and dissemination of ideas between the various cities and towns along the way.",
                        Publisher = "Tasty Minstrel Games",
                        ReleaseDate = new DateTime(2018, 11, 15),
                        ImageURL = "https://cf.geekdo-images.com/imagepage/img/e3WBinevjigRFV2VjViC4q_tPeE=/fit-in/900x600/filters:no_upscale()/pic4187672.jpg",
                        Price = 52.95f,
                        Quantity = 10
                    },
                    new BoardGame
                    {
                        Name = "Betrayal Legacy",
                        Category = "Horror",
                        Players = 3,
                        Description = "Betrayal Legacy marries the concept of Betrayal at House on the Hill — exploring a haunted mansion — with the permanency and multi-game storytelling exhibited by Daviau's Risk Legacy and other legacy games that followed.",
                        Publisher = "Wizards of the Coast",
                        ReleaseDate = new DateTime(2018, 11, 18),
                        ImageURL = "https://www.greatboardgames.ca/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/e/betrayal_legacy_back_of_box.png",
                        Price = 69.95f,
                        Quantity = 10
                    },
                    new BoardGame
                    {
                        Name = "Star Wars: Destiny – Across the Galaxy Booster Box",
                        Category = "Stars Wars",
                        Players = 2,
                        Description = "Across the Galaxy brings the block started by Legacies to its conclusion and expands on its themes. You can look forwards to plots with negative point values, cards that grow stronger when you spot specific characters, and new ways to upgrade some of the most famous vehicles in the galaxy.",
                        Publisher = "Fantasy Flight",
                        ReleaseDate = new DateTime(2018, 12, 15),
                        ImageURL = "https://www.greatboardgames.ca/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/a/c/across_the_galaxy.png",
                        Price = 113.04f,
                        Quantity = 10
                    },
                    new BoardGame
                    {
                        Name = "Condottiere",
                        Category = "Battle",
                        Players = 2,
                        Description = "Be the first leader to win four provinces in Renaissance Italy, in this classic war/card game by Dominique Ehrhard.",
                        Publisher = "Z-Man",
                        ReleaseDate = new DateTime(2019, 01, 15),
                        ImageURL = "https://www.greatboardgames.ca/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/c/o/condottiere.jpg",
                        Price = 33.99f,
                        Quantity = 10
                    },
                    new BoardGame
                    {
                        Name = "Haven",
                        Category = "Battle",
                        Players = 2,
                        Description = "In HAVEN, you and your opponent battle for control of a mystical forest. The Haven Guardian, spirit of the forest, sleeps deeply and can no longer protect its kingdom.",
                        Publisher = "Red Raven",
                        ReleaseDate = new DateTime(2019, 2, 12),
                        ImageURL = "https://www.greatboardgames.ca/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/h/a/haven_box.jpg",
                        Price = 21.95f,
                        Quantity = 10
                    },
                    new BoardGame
                    {
                        Name = "Arkham Horror",
                        Category = "Occult",
                        Players = 4,
                        Description = "Arkham Horror Third Edition is a cooperative board game for one to six players who take on the roles of investigators trying to rid the world of eldritch beings known as Ancient Ones.",
                        Publisher = "Fantasy Flight",
                        ReleaseDate = new DateTime(2018, 12, 18),
                        ImageURL = "https://www.greatboardgames.ca/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/a/r/arkham_horror_third.png",
                        Price = 72.24f,
                        Quantity = 10
                    },
                    new BoardGame
                    {
                        Name = "Endeavor: Age of Sail",
                        Category = "RTS",
                        Players = 5,
                        Description = "In Endeavor: Age of Sail, players strive to earn glory for their empires. Sailing out from Europe and the Mediterranean, players will establish shipping routes and occupy cities the world over.",
                        Publisher = "EA",
                        ReleaseDate = new DateTime(2018, 11, 15),
                        ImageURL = "https://www.greatboardgames.ca/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/e/n/endeavor_box.jpg",
                        Price = 61.95f,
                        Quantity = 10
                    },
                    new BoardGame
                    {
                        Name = "Dragonfire: Moonshae Storms",
                        Category = "Rio Grande",
                        Players = 6,
                        Description = "Moonshae Storms is the first Dragonfire Campaign Box. Face encounters from the all-new Mountain environment, and get fully equipped with new Market cards and Magic Items! Also included are eight new Characters screens, introducing the Barbarian Character Class, as well as alternate human races—the Folk and Northlanders!",
                        Publisher = "Cryptozoic",
                        ReleaseDate = new DateTime(2018, 12, 25),
                        ImageURL = "https://www.greatboardgames.ca/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/m/o/moonshae.jpg",
                        Price = 25.95f,
                        Quantity = 10
                    }
                );

                context.SaveChanges();
            }

        }

    }
}
