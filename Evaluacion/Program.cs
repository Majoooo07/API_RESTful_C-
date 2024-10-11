

var builder = WebApplication.CreateBuilder(args);

// Agrega el servicio de DbContext con la conexión a SQL Server
object value = builder.Services.AddDbContext<YourDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agrega servicios de controladores
builder.Services.AddControllers();

var app = builder.Build();

// Configura los endpoints
app.MapControllers();

app.Run();