using System.ComponentModel.DataAnnotations;

namespace eTicketsMVC5.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string Cinemalogo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
