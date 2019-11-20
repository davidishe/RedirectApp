using System;

namespace RedirectApp.Models
{
  public class CounterRecord
  {
    public int id { get; set; }
    public int userId { get; set; }
    public string userName { get; set; }
    public string createDateTime { get; set; }
    public int countValue { get; set; }
  }
}

