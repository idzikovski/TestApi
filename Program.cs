
using Microsoft.EntityFrameworkCore;
using TestApi.Data;
using TestApi.Models;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("TestConnectionString");

//builder.Services.AddDbContext<TestApiContext>(options => 
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();



app.MapGet("/", () => connString ?? "It is null");

//app.MapGet("/", async (TestApiContext dbContext) =>
//{
//    dbContext.User.Add(new User("Ivan", "Djikovski"));
//    await dbContext.SaveChangesAsync();

//    return "Hello World!";
//});

//app.MapGet("/users", (TestApiContext dbContext) =>
//{
//    return dbContext.User.Select(x => x);
//});

app.Run();
