using PracticeExam.WebApp.Models;

namespace PracticeExam.WebApp.DemoData;
public class DemoDataClass
{

    public List<string> GetDemoRegions()
    {
        return new List<string>
        {
            "Bordeaux",
            "Burgundy",
            "Champagne",
            "Loire",
            "Alsace",
            "Rhône",
            "Provence",
            "Languedoc",
            "Beaujolais"
        };
    }

    public List<Wine> GetDemoWines()
    {
        return new List<Wine>
        {
            new Wine { Id = 1, Name = "Chateau Margaux", Description = "Premier Cru Classé", Country = "France", Region = "Bordeaux", Price = 999.99m, Year = 2010 },
            new Wine { Id = 2, Name = "Domaine de la Romanee-Conti", Description = "Grand Cru", Country = "France", Region = "Burgundy", Price = 1999.99m, Year = 2015 },
            new Wine { Id = 3, Name = "Krug Clos d'Ambonnay", Description = "Blanc de Noirs", Country = "France", Region = "Champagne", Price = 2999.99m, Year = 2000 },
            new Wine { Id = 4, Name = "Clos Rougeard", Description = "Le Bourg", Country = "France", Region = "Loire", Price = 1499.99m, Year = 2005 },
            new Wine { Id = 5, Name = "Zind-Humbrecht Riesling Clos Saint Urbain Rangen de Thann Grand Cru", Description = "Vendange Tardive", Country = "France", Region = "Alsace", Price = 899.99m, Year = 2007 }
        };

    }

}
