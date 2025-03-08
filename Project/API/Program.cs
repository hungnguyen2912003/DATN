using API.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerExplorer()
                .InjectDbContext(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.ConfigureSwaggerExplorer();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
