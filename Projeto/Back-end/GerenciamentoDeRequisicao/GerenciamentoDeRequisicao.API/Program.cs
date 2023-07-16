using GerenciamentoDeRequisicao.Application.Repository;
using GerenciamentoDeRequisicao.Application.Repository.Interface;
using GerenciamentoDeRequisicao.Domain.Interface;
using GerenciamentoDeRequisicao.Infra.Data;
using GerenciamentoDeRequisicao.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RequisicaoContext>(
    _ =>
_.UseSqlServer(builder
.Configuration
.GetConnectionString("RequisicaoConnectionStrings")));

//cria apenas uma instancia por requisicao
builder.Services.AddScoped<IRequisicaoRepository, RequisicaoRepository>();
builder.Services.AddScoped<IRequisicaoRepositoryApplication, RequisicaoRepositoryApplication>();

builder.Services.AddControllers()
    .AddJsonOptions(
        options => {
            options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            //serializando o json do prioridade Enum
        }
    );

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//CORS
app.UseCors(option => option
.AllowAnyHeader()
.AllowAnyMethod()
.AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
