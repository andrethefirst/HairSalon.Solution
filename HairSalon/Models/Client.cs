using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public Client()
    {
      this.Stylists = new HashSet<Stylist>();
    }

    public int ClientId { get; set; }
    public string Type { get; set; }
    public virtual ICollection<Stylist> Stylists { get; set;}
  }
}