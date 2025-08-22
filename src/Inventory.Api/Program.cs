var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS (útil para front en dev)
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("AllowAll",
        p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

// Swagger (solo en Development por ahora)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ⚠️ Activar CORS en el pipeline
app.UseCors("AllowAll");

// (JWT llegará más adelante)
app.UseAuthorization();

app.MapControllers();

// Healthcheck simple
app.MapGet("/health", () => Results.Ok(new { status = "ok", service = "Inventory.Api" }));

app.Run();
