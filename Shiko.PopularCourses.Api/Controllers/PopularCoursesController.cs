using Microsoft.AspNetCore.Mvc;
using Shiko.PopularCourses.Api.Models;
using Shiko.PopularCourses.Api.Services;

namespace Shiko.PopularCourses.Api.Controllers;

[ApiController]
[Route("api/popular-courses")]
public class PopularCoursesController : ControllerBase
{
    private readonly PopularCourseService _popularCourseService;

    public PopularCoursesController(PopularCourseService popularCourseService)
    {
        _popularCourseService = popularCourseService;
    }

    [HttpPost("click")]
    public async Task<IActionResult> TrackClick(TrackCourseClickRequest request)
    {
        await _popularCourseService.TrackClickAsync(request);

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetPopularCourses()
    {
        var courses = await _popularCourseService.GetPopularCoursesAsync();

        return Ok(courses);
    }
}