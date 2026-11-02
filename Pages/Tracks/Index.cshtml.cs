using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_ivanov.Models;
using wt_lab5_5razor_ivanov.Data;

namespace wt_lab5_5razor_ivanov.Pages.Tracks;

public class IndexModel : PageModel
{
    public List<Track> Tracks { get; set; } = new();

    public void OnGet()
    {
        Tracks = TrackStore.Tracks;
    }

    // Метод удаления, который мы добавили в Блоке 5
    public IActionResult OnPostDelete(int id)
    {
        var track = TrackStore.Tracks.FirstOrDefault(t => t.Id == id);
        if (track != null)
        {
            TrackStore.Tracks.Remove(track);
        }
        return RedirectToPage("./Index");
    }
}