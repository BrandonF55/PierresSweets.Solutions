
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public int Calories { get; set; }
    public int FlavorId { get; set; }
    public Flavor Flavor { get; set; }
    public ApplicationUser User { get; set; }
    public List<FlavorTreat> JoinEntities { get; set;}


  }
}