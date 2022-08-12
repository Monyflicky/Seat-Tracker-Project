using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
//using System.Web.Mvc;


namespace NewSeatTracker.Pages
{
    public class ResdetailsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

         //two properties
         //one for the list
         //the other for the selected property
       [BindProperty]
       public int restaurantId {get; set;} = -1;
       public List<Restaurant> Restaurants {get; set;} //this gets all the lists
      // public IEnumerable<SelectListItem> Restaurants { get; set; }
      public Restaurant rest {get; set;}

       public ConcurrentDictionary<int, Restaurant> restDictById {get; set;} //keyes dictionaries by id's


        public ResdetailsModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnPost()
        {
            restDictById = getDictById();
            var number = Request.Form["restaurantId"];
            restaurantId = Convert.ToInt32(number);
            rest = restDictById[restaurantId];
            Restaurants = GetRestaurants();
            TempData["rest"] = JsonConvert.SerializeObject(rest);

            //return new RedirectToPageResult("Resdetails");
        }
        public void OnGet()
        {
         //Restaurant r =JsonConvert.DeserializeObject<Restaurant>(TempData["rest"].ToString());
         //rest = r;
         Restaurants = GetRestaurants();
        }
        public IActionResult OnPostReserve()
        {
            ///Restaurant r =JsonConvert.DeserializeObject<Restaurant>(TempData["rest"].ToString());
            //TempData["rest_two"] = JsonConvert.SerializeObject(r);
            return RedirectToPage("Confirmation");
        }
        public IActionResult OnPostReserve2()
        {
            ///Restaurant r =JsonConvert.DeserializeObject<Restaurant>(TempData["rest"].ToString());
            //TempData["rest_two"] = JsonConvert.SerializeObject(r);
            return RedirectToPage("mapLocation");
        }
        public List<Restaurant> GetRestaurants(){
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants.Add(new Restaurant{
                id = 2,
                name = "HotBlack Coffee",
                phonenumber = "455647645657",
                address = new Address{
                                street_number = "486",
                                street_name = "Young Avenue",
                                city = "Toronto",
                                province ="ON",
                                postalcode ="M56 657",
                                lat = 43.65044,
                                lon = -79.38864
                        },
                webLink ="https://hotblack-coffee.com/",
                capacity = 30,
                currentFilledSeats = 30
            });
            restaurants.Add(new Restaurant{
                id = 3,
                name = "StarBucks",
                phonenumber = "454464637737",
                address = new Address{
                                street_number = "529",
                                street_name = "University Avenue",
                                city = "Toronto",
                                province ="ON",
                                postalcode ="CT5 G56",
                                lat = 46.65044,
                                lon = -78.38864
                        },
                webLink ="https://www.ubereats.com/ca/brand/starbucks?utm_source=starbucks_can&utm_medium=brandpage&utm_content=Search&gclid=Cj0KCQjwg_iTBhDrARIsAD3Ib5j3jp5YFMJHkXiJix-VqNvuYeeZ1D99pxTNwn6O806Cuf-C3qmSOZ8aAoXLEALw_wcB",
                capacity = 20,
                currentFilledSeats = 10
            });
            restaurants.Add(new Restaurant{
                id = 1,
                name = "Jimmy's Coffee",
                phonenumber = "4567374437",
                address = new Address{
                                street_number = "153",
                                street_name = "Spadina Avenue",
                                city = "Toronto",
                                province ="ON",
                                postalcode ="M56 78T",
                                lat = 50.65044,
                                lon = -79.38864
                        },
                webLink ="http://www.jimmyscoffee.ca/",
                capacity = 20,
                currentFilledSeats = 5
            });
            restaurants.Add(new Restaurant{
                id = 4,
                name = "Java Joe's",
                phonenumber = "45673454646",
                address = new Address{
                                street_number = "153",
                                street_name = "Dundas St West",
                                city = "Toronto",
                                province ="ON",
                                postalcode ="M56 78T",
                                lat = 33.65044,
                                lon = -89.38864
                        },
                webLink ="http://www.jimmyscoffee.ca/",
                capacity = 15,
                currentFilledSeats = 15
            });
            //two additional restaurants
            restaurants.Add(new Restaurant{
                id = 4,
                name = "Vereda Central Coffee Roaster",
                phonenumber = "6479782308",
                address = new Address{
                                street_number = "153",
                                street_name = "Adelaide street",
                                city = "Toronto",
                                province ="ON",
                                postalcode ="M56 5T6",
                                lat = 20.65044,
                                lon = -99.38864
                        },
                webLink ="https://www.veredacentral.ca/",
                capacity = 35,
                currentFilledSeats = 0
            });
            
            restaurants.Add(new Restaurant{
                id = 4,
                name = "Dineen Coffee Co.",
                phonenumber = "4567342989",
                address = new Address{
                                street_number = "153",
                                street_name = "yonge st",
                                city = "Toronto",
                                province ="ON",
                                postalcode ="M56 3T6",
                                lat = 17.65044,
                                lon = -71.38864
                        },
                webLink ="https://www.dineencoffee.com/",
                capacity = 15,
                currentFilledSeats = 15
            });
        return restaurants;
        }

        public ConcurrentDictionary<int, Restaurant> getDictById()
        {
            ConcurrentDictionary<int, Restaurant> restDictById = new ConcurrentDictionary<int, Restaurant>();
            List<Restaurant> restaurants = GetRestaurants();
            foreach(Restaurant r in restaurants){
                restDictById.AddOrUpdate(r.id, (key) => r, (key, value) => r);
            }
            return restDictById;
        }
    }
    
    public class Restaurant{
        [Required]
        public int id {get; set;}
        [Required]
        public string name {get; set;}
        [Required]
        public string phonenumber {get; set;}
        [Required]
        public Address address {get; set;}
        [Required]
        public string webLink {get; set;}
        [Required]
        public int capacity {get; set;}
        [Required]
        public int currentFilledSeats {get; set;}
    }

    public class Address{
        [Required]
        public string street_number {get; set;}
        [Required]
        public string street_name {get; set;}
        public string city {get; set;}
        public string province {get; set;}
        [Required]
        public string postalcode {get; set;}
        [Required]
        public double lon {get; set;}
        [Required]
        public double lat {get; set;}
    }
}
