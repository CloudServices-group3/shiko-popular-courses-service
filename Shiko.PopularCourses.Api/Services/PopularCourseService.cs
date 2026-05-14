using Shiko.PopularCourses.Api.Models;

namespace Shiko.PopularCourses.Api.Services;

public class PopularCourseService
{
    private readonly List<PopularCourse> _courses = [];

    public void TrackClick(TrackCourseClickRequest request)
    {
        var existingCourse = _courses.FirstOrDefault(c => c.CourseId == request.CourseId);

        if (existingCourse is not null)
        {
            existingCourse.ClickCount++;
            existingCourse.LastClickedAt = DateTime.UtcNow;

            return;
        }

        var newCourse = new PopularCourse
        {
            CourseId = request.CourseId,
            Title = request.Title,
            Description = request.Description,
            ImageUrl = request.ImageUrl,
            ClickCount = 1,
            LastClickedAt = DateTime.UtcNow
        };

        _courses.Add(newCourse);
    }

    public List<PopularCourse> GetPopularCourses()
    {
        return _courses
            .OrderByDescending(c => c.ClickCount)
            .Take(4)
            .ToList();
    }
}