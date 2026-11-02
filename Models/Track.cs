using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_ivanov.Models;

public class Track
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите название")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Введите исполнителя")]
    public string ArtistName { get; set; } = string.Empty;

    [Range(1, 3600, ErrorMessage = "От 1 до 3600 секунд")]
    public int DurationSeconds { get; set; }
}