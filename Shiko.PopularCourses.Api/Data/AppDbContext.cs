using Microsoft.EntityFrameworkCore;
using Shiko.PopularCourses.Api.Models;

namespace Shiko.PopularCourses.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<PopularCourse> PopularCourses => Set<PopularCourse>();
}