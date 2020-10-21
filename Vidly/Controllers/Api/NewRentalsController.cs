using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            /*if (newRental.MoviesId.Count == 0)
                return BadRequest("No movies add");*/

            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            /*if (customer == null)
                return BadRequest("Customer is not valid!");*/

            var movies = _context.Movies.Where(
                m => newRental.MoviesId.Contains(m.Id)).ToList();
            
            /*if (movies.Count != newRental.MoviesId.Count)
                return BadRequest("One or more movies are invalid");*/

            foreach (var movie in movies)
            {
                if(movie.NumberAvailable==0)
                    return BadRequest("Movie is not available!");

                movie.NumberInStock--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateAdd = DateTime.Now
                };
                _context.Rental.Add(rental);
            }

            _context.SaveChanges();

            return Ok();

        }
    }
}
