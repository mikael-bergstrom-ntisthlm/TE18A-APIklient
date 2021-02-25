using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIklient
{
  public class Pokemon
  {
    public string Name { get; set;}
    
    public int Weight { get; set;}

    [JsonProperty("base_experience")]
    public int BaseExperience {get; set;}

    public List<Ability> Abilities;
  }
}
