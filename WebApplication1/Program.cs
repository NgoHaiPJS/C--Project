using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve the static index.html in wwwroot for the UI
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();