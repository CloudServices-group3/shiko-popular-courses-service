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
    public IActionResult TrackClick(TrackCourseClickRequest request)
    {
        _popularCourseService.TrackClick(request);

        return Ok();
    }

    [HttpGet]
    public IActionResult GetPopularCourses()
    {
        var courses = _popularCourseService.GetPopularCourses();

        return Ok(courses);
    }
}