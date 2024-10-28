using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Amvip.Application.Utils;
public class IgnorePropertiesJson : DefaultContractResolver
{
  private readonly HashSet<string> _ignoreProps;

  public IgnorePropertiesJson(params string[] propNamesToIgnore)
  {
    _ignoreProps = new HashSet<string>(propNamesToIgnore);
  }

  protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
  {
    JsonProperty property = base.CreateProperty(member, memberSerialization);

    if (_ignoreProps.Contains(property.PropertyName))
    {
      property.ShouldSerialize = _ => false;
    }

    return property;
  }
}