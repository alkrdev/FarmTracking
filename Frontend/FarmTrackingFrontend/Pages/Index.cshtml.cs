using System.Collections.Generic;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FarmTrackingFrontend.Models;

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

            if (response.IsSuccessStatusCode)
            {
                activeMachines = await response.Content.ReadAsAsync<IEnumerable<ActiveMachine>>();
            }

        }
    }
}
