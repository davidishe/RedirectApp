using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedirectApp.Data;
using RedirectApp.Models;


namespace RedirectApp.Controllers
{
  public class CounterController : Controller
  {
    private readonly DatabaseContext _context;
    public CounterController(DatabaseContext context)
    {
      _context = context;
    }

    // GET: 
    [HttpGet]
    public async Task<IActionResult> Index()
    {
      return Json(await _context.CounterRecords.ToListAsync());
    }

    // Create
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CounterRecord record)
    {
      if (ModelState.IsValid)
      {
        _context.Add(record);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      // return View(record);
      return View(record);
    }

    [HttpPost]
    public string AddRecord([Bind("userId, userName, createDateTime, countValue")] CounterRecord record)
    {
      if (ModelState.IsValid)
      {
        _context.Add(record);
        _context.SaveChangesAsync();
        return "Its ok";
      }
      return "Not ok";
    }

    //0HLRBDE4ARGKQ:00000002 0HLRBDE4ARGKQ:00000003

    [HttpPost]
    public string AddRecord_2(CounterRecord record)
    {
      // var record = new CounterRecord();
      // record.countValue = 123434;
      // record.createDateTime = "dsfsdfsdf";
      // record.userId = 34234;
      // record.userName = "Vasudeva";

      var response = new HttpResponseMessage();
      if (ModelState.IsValid)
      {
        _context.Add(record);
        _context.SaveChangesAsync();
        return "its ok";
      }
      return "its not ok";
    }

  }
}
