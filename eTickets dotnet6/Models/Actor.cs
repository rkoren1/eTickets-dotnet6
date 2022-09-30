using System.ComponentModel.DataAnnotations;

namespace eTickets_dotnet6.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        [Required(ErrorMessage ="Profile picture is required")]  
        public string FullName { get; set; }
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Full name must be between 3 and 50 chars")]
        public string Bio { get; set; }
        [Required(ErrorMessage = "Biography is required")]

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
