using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        public required string UserName { get; set; }
        

    }
}
