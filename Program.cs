using Projeto_Web_Lh_Pets_versão_1;

namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        var dba = new Banco();
        app.MapGet("/", () => "Projeto web - LH Pets versão 1");

        app.UseStaticFiles();
        app.MapGet("/index",(HttpContext contexto)=>{
                contexto.Response.Redirect("index.html, false");

        });

        app.MapGet("/listaClientes", (HttpContext contexto) =>{
           contexto.Response.WriteAsync( dba.GetListaString());
        });

        app.Run();
    }
}
