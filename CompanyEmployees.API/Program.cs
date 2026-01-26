using CompanyEmployees.API.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

var connectionString = Environment.GetEnvironmentVariable("SUPABASE_CONNECTION_STRING")
                       ?? throw new Exception("SUPABASE_CONNECTION_STRING not set");

Console.WriteLine($"Connection String: {Environment.GetEnvironmentVariable("SUPABASE_CONNECTION_STRING")}");


builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.AddInfrastructure(connectionString);
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureRepositoryManager(); 
builder.Services.AddControllers();


// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseDeveloperExceptionPage();
} else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});
app.UseCors("CorsPolicy");
app.UseAuthorization();
app.MapControllers();

app.Run();

