namespace eTicketsMVC5.Models
{
    public class Actor_Movie
    {
        //foreingkey for movie
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
