namespace MinimalApi.Dominio.ModelViews;

public struct Home
{

    public string Mensagem { get => "Bem vindo a API de veículos - Minimal API "; }
    public string Doc { get => "<p><a href='/swagger' target='_blank'>Swagger UI</a></p>"; }

    //public string Doc { get => "/swagger"; }
}