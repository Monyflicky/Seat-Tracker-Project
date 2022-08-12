using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace NewSeatTracker.Pages
{
    public class mapLocationModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Restaurant rest {get; set;} //restaurant being reserved
        

        public mapLocationModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Restaurant restautant  = JsonConvert.DeserializeObject<Restaurant>(TempData["rest"]?.ToString());
            rest = restautant;
        }
        
    }
}