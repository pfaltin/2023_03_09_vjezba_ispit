using System;
using PracticeExam.WebApp.DemoData;
using PracticeExam.WebApp.Models;

namespace PracticeExam.WebApp.Repositories
{
	public class WineRepository
	{

        DemoDataClass _dataClass = new DemoDataClass();
        private static List<string> Regions;
        private static List<Wine> _wines;
       

        public WineRepository()
        {
            _dataClass = new DemoDataClass();
            if (_wines == null)
            {
                _wines = _dataClass.GetDemoWines(); 
            }
        }

        public List<Wine> GetWines()
        {
            return _wines;
        }

        public void CreateNewWine(Wine Wine, int RegionId)
        {
            Wine.Region = _dataClass.GetDemoRegions().ElementAt(RegionId);
            Wine.Id = _wines.LastOrDefault().Id + 1;
            _wines.Add(Wine);
        }











    }
}

