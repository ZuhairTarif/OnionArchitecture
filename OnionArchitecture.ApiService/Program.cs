using NLog;
using OnionArchitecture.ApiService.Extensions;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

builder.Services.AddProblemDetails();
builder.Services.AddControllers();
builder.Services.ConfigureCors();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureSqlContext(builder.Configuration);

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "OnionArchitecture.ApiService v1");
    });
    app.MapOpenApi();
}


app.UseExceptionHandler("/error");
app.UseForwardedHeaders();
app.UseStaticFiles();
app.UseCors("CorsPolicy");
app.UseHsts();

app.MapControllers();


app.Run();