using System;
using Newtonsoft.Json;

namespace APIklient
{
  public class Ability
  {
    public string Name {get; set;}

    [JsonProperty("ability")]
    public AbilityName TheAbilityName
    { 
      set {
        Name = value.Name;
      }
    }

    [JsonProperty("is_hidden")]
    public bool IsHidden {get; set;}

  }
}
