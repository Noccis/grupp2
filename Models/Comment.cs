
using System.ComponentModel.DataAnnotations;

namespace Grupp2.Models;

public class Comment 
{
    [Required]
    public string Body { get; set; } = null!;

    public string Email { get; set; } = string.Empty;

    [Required]
    public string Author { get; set; } = null!;
}
