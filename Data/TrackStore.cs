using wt_lab5_5razor_ivanov.Models;

namespace wt_lab5_5razor_ivanov.Data;

public static class TrackStore
{
    public static List<Track> Tracks { get; } = new()
    {
        new Track { Id = 1, Title = "Bohemian Rhapsody", ArtistName = "Queen", DurationSeconds = 355 },
        new Track { Id = 2, Title = "Imagine", ArtistName = "John Lennon", DurationSeconds = 183 },
        new Track { Id = 3, Title = "Love of My Life", ArtistName = "Queen", DurationSeconds = 219 },
        new Track { Id = 4, Title = "Billie Jean", ArtistName = "Michael Jackson", DurationSeconds = 294 }
    };
}