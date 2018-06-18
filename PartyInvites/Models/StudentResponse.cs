using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class StudentResponse
    {
        [Required(ErrorMessage = "try that again")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Must make a selection"]
        public string choice { get; set; }
        
    }
}
