using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FarmTrackingFrontend.Pages
{
    public class AddOrRemoveModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Machine Machine { get; set; }


        [BindProperty(SupportsGet = true)]
        public Field Field { get; set; }
        public void OnGet()
        {

        }
    }
}