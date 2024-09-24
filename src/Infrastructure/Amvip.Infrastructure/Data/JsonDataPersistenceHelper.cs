// using Amvip.Domain.Models.DTOs.Getters;
// using Amvip.Domain.Models.Entities;
// using Newtonsoft.Json;

// namespace Amvip.Infrastructure.Data;

// public static class JsonDataPersistenceHelper
// {
//   public static List<PersonalData> PersonalData {get; private set;}

//   // Init from ./ = root project directory
//   private static readonly string _jsonFile = "./JsonDataBase.json";
//   private static bool _isLoaded = false;

//   public static void LoadData()
//   {
//     if(_isLoaded)
//       return;
    
//     Init();

//     string dataJson = GetDataBaseJson();

//     if(String.IsNullOrEmpty(dataJson))
//       return;

//     var data = JsonConvert.DeserializeObject<dynamic>(dataJson);

//     foreach (var entry in data[nameof(BaseContext.PersonalData)])
//     {
//       PersonalDataDto personalData = JsonConvert.DeserializeObject<PersonalData>(entry.ToString());
//       PersonalData.Add(personalData);
//     }

//     _isLoaded = true;
//   }

//   private static string GetDataBaseJson()
//   {
//     if (!File.Exists(_jsonFile))
//       throw new Exception("JsonDataBase doesn't exist");

//     var jsonData = File.ReadAllText(_jsonFile);

//     return jsonData;
//   }

//   private static void Init()
//   {
//     PersonalData = new List<PersonalData>();
//   }
// }