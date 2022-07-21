using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Notes.Models
{
    public class Note
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title cant be null or empty")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Description cant be null or empty")]
        public string Description { get; set; }
    }
}
