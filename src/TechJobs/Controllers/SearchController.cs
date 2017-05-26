using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        public IActionResult Result(string searchType, string searchTerm)
        {
            List<Dictionary<string, string>> jobResults;

            if (searchType.Equals("all"))
            {
               jobResults = JobData.FindByValue(searchTerm);
            }
            else
            {
                jobResults = JobData.FindByColumnAndValue(searchType, searchTerm);
            }

            ViewBag.jobs = jobResults;

            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";

            return View("Index");
        }

        private void FindByValue(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
