using Microsoft.EntityFrameworkCore;
using Shiko.PopularCourses.Api.Data;
using Shiko.PopularCourses.Api.Models;

namespace Shiko.PopularCourses.Api.Services;

public class PopularCourseService
{
    private readonly AppDbContext _context;

    public PopularCourseService(AppDbContext context)
    {
        _context = context;
    }

    public async Task TrackClickAsync(TrackCourseClickRequest request)
    {
        var existingCourse = await _context.PopularCourses
            .FirstOrDefaultAsync(c => c.CourseId == request.CourseId);

        if (existingCourse is not null)
        {
            existingCourse.ClickCount++;
            existingCourse.LastClickedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return;
        }

        var newCourse = new PopularCourse
        {
            CourseId = request.CourseId,
            Title = request.Title,
            Description = request.Description,
            IconUrl = request.IconUrl,
            ClickCount = 1,
            LastClickedAt = DateTime.UtcNow
        };

        _context.PopularCourses.Add(newCourse);

        await _context.SaveChangesAsync();
    }

    public async Task<List<PopularCourse>> GetPopularCoursesAsync()
    {
        return await _context.PopularCourses
            .OrderByDescending(c => c.ClickCount)
            .Take(4)
            .ToListAsync();
    }
}