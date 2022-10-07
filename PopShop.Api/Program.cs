using PopShop.Api.Configurations;
using PopShop.Api.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>();

builder.Services.AddHttpClient(ApiBaseUrl.VIA_CEP, c => c.BaseAddress = new Uri("https://viacep.com.br/ws/"));
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
