using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Scott's Pizzaa", Location="Marryland", Cuisine=CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Geno's Food", Location="New York", Cuisine=CuisineType.Mexican},
                new Restaurant {Id = 3, Name = "I am Ivan", Location="California", Cuisine=CuisineType.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
