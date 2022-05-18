using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using System;
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

        public void OnGet()
        {
    
          Restaurants = GetRestaurants();
         
        }
        public void OnPost()
        {
            restDictById = getDictById();
            var number = Request.Form["restaurantId"];
            restaurantId = Convert.ToInt32(number);
            rest = restDictById[restaurantId];
            Restaurants = GetRestaurants();

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
                                postalcode ="M56 657"
                        },
                webLink ="https://hotblack-coffee.com/"
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
                                postalcode ="CT5 G56"
                        },
                webLink ="https://www.ubereats.com/ca/brand/starbucks?utm_source=starbucks_can&utm_medium=brandpage&utm_content=Search&gclid=Cj0KCQjwg_iTBhDrARIsAD3Ib5j3jp5YFMJHkXiJix-VqNvuYeeZ1D99pxTNwn6O806Cuf-C3qmSOZ8aAoXLEALw_wcB"
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
                                postalcode ="M56 78T"
                        },
                webLink ="http://www.jimmyscoffee.ca/"
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
    }
    /*public static class SelectList
    {
        public static List<SelectListItem> Create<TEnum>
            (bool includeEmptyOption = false)
        {
            var type = typeof(TEnum);
            if (!type.IsEnum)
            {
                throw new ArgumentException(
                    "type must be an enum",
                    nameof(type)
                );
            }

            var result =
                Enum
                    .GetValues(type)
                    .Cast<TEnum>()
                    .Select(v => 
                        new SelectListItem(
                        v.ToString(),
                        v.ToString()
                        )
                    )
                    .ToList();

            if (includeEmptyOption)
            {
                // Insert the empty option
                // at the beginning
                result.Insert(
                    0, 
                    new SelectListItem("Pick An Option", "")
                );
            }

            return result;
        }
    }*/
}
