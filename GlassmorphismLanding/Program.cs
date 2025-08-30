var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// wwwroot içindeki içerikleri otomatik sun
app.UseDefaultFiles();  // index.html önceliklendirilir
app.UseStaticFiles();   // css/js/img dosyalarý

// (Opsiyonel) SPA/tek sayfa fallback'i gerekirse aç:
// app.MapFallbackToFile("index.html");

app.Run();