using Microsoft.EntityFrameworkCore;
using ToDoGrpc.Models;

namespace ToDoGrpc.Data;

public class AppDbContext : DbContext
{
    public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}