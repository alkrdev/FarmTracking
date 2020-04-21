using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FarmTrackingFrontend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace FarmTrackingFrontend.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<ActiveMachine> activeMachines { get; set; }

        public IndexModel()
        {

        }

        public async Task OnGetAsync() {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44387/activemachines");

            if (response.IsSuccessStatusCode)
            {
                activeMachines = await response.Content.ReadAsAsync<IEnumerable<ActiveMachine>>();
            } 
        }
    }
}
