var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
const string corsName = "All";
builder.Services.AddCors(options =>
{
    options.AddPolicy(corsName, builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
var app = builder.Build();
app.UseCors(corsName);
app.UseRouting();
app.MapControllers();
app.Run();