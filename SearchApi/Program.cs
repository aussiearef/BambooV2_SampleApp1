using System.Net;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(b =>
    {
        b.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();
app.UseCors();

app.MapGet("/search",  () =>
{
    return new HttpResponseMessage(HttpStatusCode.OK){
        Content = new StringContent("Hello!")
    };
});



app.Run();