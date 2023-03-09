using Microsoft.AspNetCore.Mvc;
using PracticeExam.WebApp.Models;
using PracticeExam.WebApp.Repositories;

namespace PracticeExam.WebApp.Controllers;

public class WineController : Controller
{
    private WineRepository _WineRepository;

    // DI 
    public WineController(WineRepository WineRepository)
    {
        _WineRepository = WineRepository;
    }


    public IActionResult Index()
    {
        // TODO: ispis svih vina u kolekciji
        return View();
    }

    public IActionResult Create()
    {
        // Prikaz pogleda za unos novog vina na listu
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateWine()
    {
        // TODO:  logika za unos podataka dobivenih iz HTML forme
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            return View();
        }
    }
}
