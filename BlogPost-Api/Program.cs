using BlogPost_Api.Data;
using BlogPost_Api.Repo.Reaction_Reprosatariy;
using BlogPost_Api.Repo.User_Reposiatiry;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppdbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("newcon")));
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IReactionRepo, ReactionRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
