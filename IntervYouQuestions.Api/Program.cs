using IntervYouQuestions.Api.Persistence;
using Microsoft.EntityFrameworkCore;
using SurveyBasket.Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDependencies();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<InterviewModuleContext>(options => options.UseSqlServer());

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
