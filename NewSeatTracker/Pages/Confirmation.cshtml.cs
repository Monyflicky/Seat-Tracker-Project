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
    public class ConfirmationModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Restaurant restautant {get; set;} //restaurant being reserved
        
        public string acceptanceMessage {get; set;}
        public string thankNoteMessage {get; set;}
        public bool isVacant {get; set;}

        public ConfirmationModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Restaurant restautant  = JsonConvert.DeserializeObject<Restaurant>(TempData["rest"]?.ToString());
          
            if(restautant != null)
            {
                if(restautant.currentFilledSeats == restautant.capacity)
                {
                      isVacant = false; //restaurant has no capacity
                      acceptanceMessage = "No Vacancy at the moment";
                      thankNoteMessage = "Thank you for working with us today!";
                }
                else if(restautant.currentFilledSeats < restautant.capacity)
                {
                       isVacant = true; //restaurant has no capacity
                       acceptanceMessage = "A spot has been saved for you!";
                       restautant.currentFilledSeats += 1;
                       thankNoteMessage = "Thank you for working with us today!";
                }
                else
                {

                }
            }

        }
        
    }
}
