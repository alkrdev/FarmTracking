using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BackendLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http.Formatting;

namespace FarmTrackingFrontend.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public Machine Machine { get; set; }

        public IEnumerable<ActiveMachine> activeMachines { get; set; }

        public IndexModel()
        {

        }

        public async void OnGet() {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44387/activemachines");

            if (response.IsSuccessStatusCode) {
        public async void OnGet()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44387/activemachines");

            if (response.IsSuccessStatusCode)
            {
                activeMachines = await response.Content.ReadAsAsync<ActiveMachine>();
            }

        }
    }
}
