using Microsoft.EntityFrameworkCore;
using ToDoGrpc.Data;
using ToDoGrpc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite("Data source=ToDoDatabase.db"));

builder.Services.AddGrpc().AddJsonTranscoding();

var app = builder.Build();

app.MapGrpcService<ToDoService>();

app.Run();