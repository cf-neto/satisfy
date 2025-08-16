using System.ComponentModel.DataAnnotations;

namespace Satisfy.Models;

public class Feedback
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Nome { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [Range(1, 5)]
    public int Nota { get; set; }

    [Required]
    [MaxLength(1000)]
    public string? Comentario { get; set; }

    public DateTime DataEnvio { get; set; } = DateTime.UtcNow;


}