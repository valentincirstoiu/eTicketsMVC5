using System.ComponentModel.DataAnnotations;

namespace eTicketsMVC5.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string Fullname { get; set; }
        public string Bio { get; set; }
    }
}
