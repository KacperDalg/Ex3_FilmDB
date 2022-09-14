using System.ComponentModel.DataAnnotations;

namespace FilmBase.Models;
public class Actor
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Surname { get; set; }
    [Required]
    public string Name { get; set; }
    public List<Film> Films { get; set; } = new List<Film>();
}