using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection;
using Newtonsoft.Json;
using eBilet.Entity;

namespace eBilet.Web.Controllers
{
    public class UcusController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> List(Flight flight)
        {
            List<Flight> flights;
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://localhost:7166/api/flight/getallflight");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                flights = JsonConvert.DeserializeObject<List<Flight>>(json);
            }
            return View(flights);
        }

        [HttpPost]
        public async Task<IActionResult> Details(int Id)
        {
            List<Flight> flights;
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://localhost:7166/api/flight/getallflight");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                flights = JsonConvert.DeserializeObject<List<Flight>>(json);
            }
            return View(flights);
        }
    }
}
