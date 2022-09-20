using Microsoft.EntityFrameworkCore;
using myApi.Helper;

const string corsPolicy = "_corsPolicy";
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// cors
builder.Services.AddCors(
    options =>
    {
        options.AddPolicy(name: corsPolicy,
            policy =>
            {
                policy.WithOrigins("*")
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            }
        );

    }
);

//DbContext
builder.Services.AddDbContext<DataContext>(
    context =>
    {
        context.EnableSensitiveDataLogging();
        context.UseNpgsql(builder.Configuration.GetConnectionString("myApiDatabase"));
    }
);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UpdateDatabase();

app.UseCors(corsPolicy);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers()
    .RequireCors(corsPolicy);

app.Run();