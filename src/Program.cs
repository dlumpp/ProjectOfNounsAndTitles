using ProjectOfNounsAndTitles;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Title.CreateTitle());

app.Run();
