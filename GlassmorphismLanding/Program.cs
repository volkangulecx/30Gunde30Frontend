var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// wwwroot i�indeki i�erikleri otomatik sun
app.UseDefaultFiles();  // index.html �nceliklendirilir
app.UseStaticFiles();   // css/js/img dosyalar�

// (Opsiyonel) SPA/tek sayfa fallback'i gerekirse a�:
// app.MapFallbackToFile("index.html");

app.Run();