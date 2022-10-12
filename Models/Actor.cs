using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicketsMVC5.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name ="Profile Picture URL")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full name must be betweeen 3 and 50 chars")]
        public string Fullname { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        //Relationships
        public List<Actor_Movie> Actor_Movies{ get; set; }
    }
}
