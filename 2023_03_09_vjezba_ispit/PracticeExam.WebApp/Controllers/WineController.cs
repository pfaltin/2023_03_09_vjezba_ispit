using AspNetCore;
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
        return View(_WineRepository.GetWines());
    }

    public IActionResult Create()
    {
        // Prikaz pogleda za unos novog vina na listu
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateWine(
        string? name,
        string? description,
        string? country,
        string? region,
        decimal? price,
        int? year
        )
    {
        // TODO:  logika za unos podataka dobivenih iz HTML forme

        ViewBag.Name = name;
        ViewBag.Description = description;
        ViewBag.Country = country;
        ViewBag.Region = region; 
        ViewBag.Price = price;
        ViewBag.Year = year;

        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            return View("Views_Wine_Index");
        }
    }
}
