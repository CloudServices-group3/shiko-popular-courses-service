namespace Shiko.PopularCourses.Api.Models;

public class TrackCourseClickRequest
{
    public string CourseId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? IconUrl { get; set; }
}