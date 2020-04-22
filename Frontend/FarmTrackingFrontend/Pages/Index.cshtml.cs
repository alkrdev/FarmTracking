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

        [BindProperty(SupportsGet = true)]
        public ActiveMachine machine { get; set; }

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
        public async Task<IActionResult> DeleteActiveMachine(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync("https://localhost:44387/activemachines/" + id);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToPage("/index");
            }

            return RedirectToPage("/index");
        }


        public IActionResult OnPost(int id)
        {
            DeleteActiveMachine(id);
            return RedirectToPage("/index");
        }
    }
}
