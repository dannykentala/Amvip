using Amvip.Domain.Models.Entities;
using Amvip.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
      base.SaveChanges();

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

    var data = ExportDataBase();


    JsonSerializerSettings ignoreLoopReference = new JsonSerializerSettings()
    {
      ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
      PreserveReferencesHandling = PreserveReferencesHandling.None,
      // ContractResolver = 
      // NullValueHandling = NullValueHandling.Ignore,

    };

    // string json = JsonSerializer.SerializeObject(data, Formatting.Indented, ignoreLoopReference);
    // string json = (data, Formatting.Indented, ignoreLoopReference);
    string json = JsonConvert.SerializeObject(data, Formatting.Indented);
    File.WriteAllText(_jsonFile, json);

    return changes;
  }
  
  private object ExportDataBase()
  {
    // Well I have some errors with when serializing (EF mapping), so I seriealize every entity individualy

    return new
    {
      PersonalData = IgnoreProperties.ListAndIgnoreProperties(PersonalData),
      Users = IgnoreProperties.ListAndIgnoreProperties(Users),
      Partners = IgnoreProperties.ListAndIgnoreProperties(Partners),
      SuscriptionDetails = IgnoreProperties.ListAndIgnoreProperties(SuscriptionDetails),
      Suscriptions = IgnoreProperties.ListAndIgnoreProperties(Suscriptions),
      Invitations = IgnoreProperties.ListAndIgnoreProperties(Invitations)
    };
  }

  // private object ExportDataBase()
  // {
  //   return new
  //   {
  //     PersonalData = PersonalData.ToList(),
  //     Users = Users.ToList(),
  //     Partners = Partners.ToList(),
  //     SuscriptionDetails = SuscriptionDetails.ToList(),
  //     Suscriptions = Suscriptions.ToList(),
  //     Invitations = Invitations.ToList()
  //   };
  // }


  private void GetDataBase()
  {
    string jsonData = GetDataBaseJson();

    if(String.IsNullOrEmpty(jsonData))
      return;

    var data = JsonConvert.DeserializeObject<dynamic>(jsonData);

    AddToDbSet(PersonalData, data);
    AddToDbSet(Users, data);
    AddToDbSet(Partners, data);
    AddToDbSet(SuscriptionDetails, data);
    AddToDbSet(Suscriptions, data);
    AddToDbSet(Invitations, data);
  }

  private string GetDataBaseJson()
  {
    if (!File.Exists(_jsonFile))
      throw new Exception("JsonDataBase doesn't exist");

    var jsonData = File.ReadAllText(_jsonFile);

    return jsonData;
  }

  private void AddToDbSet<TEntity>(DbSet<TEntity> set, dynamic data) where TEntity: class
  {
    string setName = typeof(TEntity).Name;
    setName = ParseDataBaseName(setName);

    // data can have multiple schemas, so first we have to validate if we have data from this schema
    if(data[setName] != null)
    {
      foreach (var entry in data[setName])
      {
        /* This is a little bit strange, because i'm using DbSet but it is getting original object 
        */
        var myEntity =JsonConvert.DeserializeObject<TEntity>(entry.ToString()) ;
        set.Add(myEntity);
      }
    }
  }

  private string ParseDataBaseName(string modelName)
  {
    switch (modelName)
    {
      case "PersonalData":
        // Don't make any change, because database is in singular
        break;
      default:
        // Databases are in pural
        modelName = $"{modelName}s";
        break;
    }
    return modelName;
  }
}