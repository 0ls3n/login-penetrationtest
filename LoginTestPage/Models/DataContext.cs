using Microsoft.EntityFrameworkCore;

namespace LoginTestPage.Models;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}