using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWeelsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CWeelsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle(){Id=1,Title="Tesla X",Price=23000},
            new Vehicle(){Id=2,Title="Tesla S",Price=29000},
            new Vehicle(){Id=3,Title="Tesla Z",Price=27000}
        };

        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return vehicles;
        }

        [HttpPost]
        public void Post([FromBody]Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Vehicle vehicle)
        {
            vehicles[id] = vehicle;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            vehicles.RemoveAt(id);
        }
    }
}


