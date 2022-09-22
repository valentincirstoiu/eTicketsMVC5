using System.ComponentModel.DataAnnotations;
using System;
using eTicketsMVC5.Data.Enums;

namespace eTicketsMVC5.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //FROM folder Data MovieCategory
        public MovieCategory MovieCategory { get; set; }
    }
}
