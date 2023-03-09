using System;
using PracticeExam.WebApp.DemoData;
using PracticeExam.WebApp.Models;

namespace PracticeExam.WebApp.Repositories
{
	public class WineRepository
	{
        public WineRepository()
        {
        }
        DemoDataClass dataClass = new DemoDataClass();
        private static List<string> Regions;
        private static List<Wine> _wines;
        

        public WineRepository()
        {
            _dataClass = new DemoDataClass();
            if (Wines == null)
            {
                Wines = new List<Wine>();
                SimulateDatabase();
            }
        }

        public List<Wine> GetWines()
        {
            return Wines;
        }

        public void CreateNewWine(Wine Wine, int RegionId)
        {
            Wine.Region = _RegionRepo.GetRegionById(RegionId);
            Wine.WineId = Wines.LastOrDefault().WineId + 1;
            Wines.Add(Wine);
        }











    }
}

