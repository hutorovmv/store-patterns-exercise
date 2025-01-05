var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
MapRoutes(app);
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
UseSwaggerForDevelopment(app);

app.Run();

static void MapRoutes(WebApplication app) {
  app.MapGet("/test", () =>
  {
    return "test";
  }).WithName("test");
}

static void UseSwaggerForDevelopment(WebApplication app) {
  if (app.Environment.IsDevelopment())
  {
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
  }
}
