using MongoDB.Driver;
using SoapCore;
using SoapMongoProject.Contracts;
using SoapMongoProject.Models;
using SoapMongoProject.Repositories;
using SoapMongoProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Configura��es do MongoDB
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDBSettings"));
builder.Services.AddSingleton<IMongoClient>(sp =>
    new MongoClient(builder.Configuration.GetSection("MongoDBSettings:ConnectionString").Value));

// Reposit�rios e Servi�os
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IUserService, UserService>();

// Adiciona SOAP
builder.Services.AddSoapCore();
builder.Services.AddTransient<IUserService, UserService>();

var app = builder.Build();

// Middleware SOAP
app.UseRouting();

// Expondo o WSDL corretamente com SoapCore
app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<IUserService>("/UserService.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();
