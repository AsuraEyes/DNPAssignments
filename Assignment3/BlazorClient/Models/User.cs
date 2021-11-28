using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorClient.Models
{
    public class User
    {

        public int Id { get; set; }

        [Required, MaxLength(15, ErrorMessage = "Username too long")]
        public string UserName { get; set; }
        [Required, MinLength(4, ErrorMessage = "Password too short, minimum 4 characters")]
        public string Password { get; set; }

        public string Role { get; set; }
        

        public int SecurityLevel { get; set; }
    }
}