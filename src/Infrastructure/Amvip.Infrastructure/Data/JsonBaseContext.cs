using Amvip.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Amvip.Infrastructure.Data;
public class JsonBaseContext : BaseContext
{
  // Init from ./ = root project directory
  private readonly string _jsonFile = "./JsonDataBase.json";
  private static bool _isLoaded = false;

  public JsonBaseContext(DbContextOptions<JsonBaseContext> options) : base(options)
  {
    if(!_isLoaded)
    {
      GetDataBase();
      _isLoaded = true;
    }
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseInMemoryDatabase("JsonDataBase");
  }

  // protected override void OnModelCreating(ModelBuilder modelBuilder)
  // {
  //   JsonDataPersistenceHelper.LoadData();

  //   PersonalData.AddRange(JsonDataPersistenceHelper.PersonalData);

  //   base.OnModelCreating(modelBuilder);
  // }

  public override int SaveChanges()
  {
    int changes = base.SaveChanges();

    var data = new
    {
      PersonalData = PersonalData.ToList()
    };

    string json = JsonConvert.SerializeObject(data, Formatting.Indented);
    File.WriteAllText(_jsonFile, json);

    return changes;
  }

  private void GetDataBase()
  {
    string jsonData = GetDataBaseJson();

    if(String.IsNullOrEmpty(jsonData))
      return;

    var data = JsonConvert.DeserializeObject<dynamic>(jsonData);

    foreach (var entry in data[nameof(BaseContext.PersonalData)])
    {
      PersonalData.Add(JsonConvert.DeserializeObject<PersonalData>(entry.ToString()));
    }

  }

  private string GetDataBaseJson()
  {
    if (!File.Exists(_jsonFile))
      throw new Exception("JsonDataBase doesn't exist");

    var jsonData = File.ReadAllText(_jsonFile);

    return jsonData;
  }

}