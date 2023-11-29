using Microsoft.EntityFrameworkCore;
using TestApi.Models;

namespace TestApi.Data;

public class TestApiContext(DbContextOptions<TestApiContext> options) : DbContext(options)
{
    public DbSet<User> User => Set<User>();
}