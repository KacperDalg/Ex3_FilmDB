using System.ComponentModel.DataAnnotations;

namespace FilmBase.Models;
public class Film
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public List<Actor> Actors { get; set; } = new List<Actor>();
}