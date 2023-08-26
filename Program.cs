var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();


var app = builder.Build();

/* Configurações para tonar a aplicação acessivel via Browser */
app.UseHttpsRedirection();
app.UseStaticFiles(); // utiliza o (wwwroot) css, js, images etc..

// Auxiliar no mapeamento das paginas
app.UseRouting();
app.MapRazorPages();

app.Run();
