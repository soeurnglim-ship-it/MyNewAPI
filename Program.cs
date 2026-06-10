var builder = WebApplication.CreateBuilder(args);

// 1. Add services to the dependency injection container.
builder.Services.AddControllers();



var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

// 3. Map attribute-routed controllers
app.MapControllers();

app.Run();