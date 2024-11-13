# CodeFirst2 Project

This project demonstrates the use of Entity Framework Core with a Code First approach to create a database with `User` and `Post` tables and their relationships.

## Prerequisites

- .NET 6.0 SDK or later
- PostgreSQL
- Visual Studio or JetBrains Rider

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/CodeFirst2.git
cd CodeFirst2
```

### 2. Configure the Database Connection

Update the connection string in `appsettings.json` or `Program.cs` to match your PostgreSQL configuration.

### 3. Apply Migrations

Generate and apply the initial migration to create the database schema.

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Run the Application

Start the application using the .NET CLI or your preferred IDE.

```bash
dotnet run --project CodeFirst2.WebApi
```

## Project Structure

- `CodeFirst2.WebApi`: Contains the API project.
- `CodeFirst2.Dataa`: Contains the data access layer, including the `DbContext` and entity classes.

## Entity Classes

### UserEntity

```csharp
public class UserEntity : BaseEntity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public ICollection<PostEntity> Posts { get; set; }
}
```

### PostEntity

```csharp
public class PostEntity : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int UserId { get; set; }
    public UserEntity UserEntity { get; set; }
}
```

## DbContext Configuration

### CodeFirst2DbContext

```csharp
public class CodeFirst2DbContext : DbContext
{
    public CodeFirst2DbContext(DbContextOptions<CodeFirst2DbContext> options) : base(options) { }
    
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<PostEntity> Posts { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CodeFirstDb2;Username=cagdasergenc;Password=cagdasergenc");
    }
}
```

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
