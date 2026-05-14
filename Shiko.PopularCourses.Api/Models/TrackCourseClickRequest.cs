namespace Shiko.PopularCourses.Api.Models;

public class TrackCourseClickRequest
{
    public string CourseId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Descritpion { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
}