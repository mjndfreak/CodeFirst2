using CodeFirst2.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst2.Dataa.Context;

public class CodeFirst2DbContext : DbContext
{
    public CodeFirst2DbContext(DbContextOptions<CodeFirst2DbContext> options) : base(options)
    {
        
    }
    
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<PostEntity> Posts { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CodeFirstDb2;Username=cagdasergenc;Password=cagdasergenc");
    }
}