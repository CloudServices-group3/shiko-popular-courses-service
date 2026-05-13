namespace Shiko.PopularCourses.Api.Models;

public class PopularCourse
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string CourseId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public int ClickCount { get; set; }
    public DateTime LastClickedAt { get; set; } = DateTime.UtcNow;
}