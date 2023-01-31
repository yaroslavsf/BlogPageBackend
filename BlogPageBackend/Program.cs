using BlogPageBackend.Data;
using BlogPageBackend.Data.Repositories;
using BlogPageBackend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


 
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("MSSQL");
builder.Services.AddDbContext<BlogDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<BlogDbContext>();


builder.Services.AddTransient<ILikeRepository, LikeRepository>();
builder.Services.AddTransient<IUserRepository, CommentRepository>();
builder.Services.AddTransient<IPostRepository, PostRepository>();

builder.Services.AddScoped<ILikeService, LikeService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IPostService, PostService>();
/*builder.Services.AddScoped<IAuthService, AuthService>();*/




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
