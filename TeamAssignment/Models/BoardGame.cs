using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamAssignment.Models
{
    public class BoardGame
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide game name.")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please provide category.")]
        public String Category { get; set; }

        [Required(ErrorMessage = "Please provide maximum number of players.")]
        public int Players { get; set; }

        [Required(ErrorMessage = "Please provide game description.")]
        public String Description { get; set; }

        [Required(ErrorMessage = "Please provide publisher.")]
        public String Publisher { get; set; }

        [Required(ErrorMessage = "Please provide release date.")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please provide image url.")]
        public String ImageURL { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }
    }
}
