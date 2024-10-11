using minimal_api.Dominio.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO loginDTO) => {
    
    if(loginDTO.Email == "admin@teste.com" && loginDTO.Senha == "123456") 
        return Results.Ok("Login feito com sucesso") as IResult;
    else
        return Results.Unauthorized() as IResult;
});


app.Run();

