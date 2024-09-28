using Amvip.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Amvip.Infrastructure.Data;
public class BaseContext : DbContext
{
  public JsonBaseContext context;

  public BaseContext(DbContextOptions<BaseContext> options) : base(options)
  { }

  protected BaseContext(DbContextOptions options) : base(options)
  { }

  public DbSet<PersonalData> PersonalData { get; set; }
}