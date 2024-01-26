using System.ComponentModel.DataAnnotations;

namespace Project.DTO
{
    public class UserRegisterRequestDTO
    {

        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserContactNumber { get; set; }

        [Required]
        public string UserEmail { get; set; }


        [Required]
        public string UserMessage { get; set; }
    }
}
