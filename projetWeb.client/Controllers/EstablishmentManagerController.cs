using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using projetWeb.client.Models;

namespace projetWeb.client.Controllers
{
    public class EstablishmentManagerController : Controller
    {
        private readonly HttpClient client = null;
        private string establishmentApiUrl = "";
        private string countriesApiUrl = "";
        public EstablishmentManagerController(HttpClient client, IConfiguration config)
        {
            this.client = client;
            establishmentApiUrl = config.GetValue<string>("AppSettings:EstablishmentApiUrl");
            countriesApiUrl = config.GetValue<string>("AppSettings:CountriesApiUrl");
        }

        public async Task<bool> FillCountriesAsync()
        {

        }

        public async Task<IActionResult> ListAsync()
        {
            HttpResponseMessage response = await client.GetAsync(establishmentApiUrl);
            // The ReadAsStringAsync() method reads the actual JSON content
            // from the HttpResponseMessage object.
            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<Establishment> data = JsonSerializer.Deserialize<List<Establishment>>(stringData, options);
            return View(data);

        }

        public async Task<IActionResult> InsertAsync()
        {
            await FillCountriesAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertAsync(Establishment model)
        {
            await FillCountriesAsync();
            if (ModelState.IsValid)
            {
                string stringData = JsonSerializer.Serialize(model);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(establishmentApiUrl, contentData);
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Establishment inserted successfully!";
                }
                else
                {
                    ViewBag.Message = "Error while calling Web API!";
                }
            }
            return View(model);
        }

        public async Task<IActionResult> UpdateAsync(int id)
        {

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateAsync(Establishment model)
        {

        }

        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDeleteAsync(int id)
        {

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAsync(int EstablishmentID)
        { }
    }
}
