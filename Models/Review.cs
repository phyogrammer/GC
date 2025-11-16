using System;

namespace GameCatcher.Models;

public class Review
{
    public long GameId { get; set; }
    public string? Comment { get; set; }
    public DateTime CreatedAt { get; set; }
}
