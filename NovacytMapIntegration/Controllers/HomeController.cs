using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NovacytMapIntegration.Models;
using NovacytMapIntegration.Repositories;

namespace NovacytMapIntegration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILocationsRepository _locationsRepository;

        public HomeController( ILocationsRepository locationsRepository)
        {
            //Always a fan of Service-Repo pattern
            // but for now it goes against the YAGNI principle

            _locationsRepository = locationsRepository;
        }

        public async Task<IActionResult> Index()
        {
            var locations = await _locationsRepository.GetAllLocations();
            return View(locations);
        }

    }
}
