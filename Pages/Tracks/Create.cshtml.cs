using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_ivanov.Models;
using wt_lab5_5razor_ivanov.Data;

namespace wt_lab5_5razor_ivanov.Pages.Tracks;

public class CreateModel : PageModel
{
    [BindProperty]
    public Track NewTrack { get; set; } = new();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page(); // Если есть ошибки, вернуть форму
        }

        NewTrack.Id = TrackStore.Tracks.Any() ? TrackStore.Tracks.Max(t => t.Id) + 1 : 1;
        TrackStore.Tracks.Add(NewTrack);

        return RedirectToPage("./Index"); // Переход на список
    }
}