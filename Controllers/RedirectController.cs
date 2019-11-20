using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedirectApp.Controllers;
using RedirectApp.Models;

namespace RedirectApp.Controllers
{

  public class SystemDateTime : IDateTime
  {
    public DateTime Now
    {
      get { return DateTime.Now; }
    }
  }

  public class RedirectController : ControllerBase
  {


    [HttpPost]
    public async void Redirect(CounterController controller)
    {
      var record = new CounterRecord();
      record.countValue = 1;
      record.userName = "Semen";
      record.userId = 22;
      // await controller.Create(record);
    }

    public IActionResult RedirectToPage()
    {
      return new RedirectResult("https://sharelock.space");
    }

    [HttpGet]
    public string GetCounter()
    {
      return ToString();
    }

    [HttpGet]
    public int SomeApi()
    {
      return 0;
    }

  }
}
