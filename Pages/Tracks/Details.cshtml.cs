using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_ivanov.Models;
using wt_lab5_5razor_ivanov.Data;

namespace wt_lab5_5razor_ivanov.Pages.Tracks;

public class DetailsModel : PageModel
{
    public Track? TrackItem { get; set; }

    public IActionResult OnGet(int id)
    {
        TrackItem = TrackStore.Tracks.FirstOrDefault(t => t.Id == id);
        if (TrackItem == null) return NotFound();
        return Page();
    }
}