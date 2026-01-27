using System.ComponentModel.DataAnnotations;

namespace MiniApiFramework.Models
{
    public class CreatePostRequest
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Body { get; set; } = null!;
    }
}