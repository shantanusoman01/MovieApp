using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetailController : ControllerBase
    {
            MovieContext context=new MovieContext();
            [HttpGet]
            [Route("ListDetails")]
         public IActionResult Get(){
         
            //var data=context.Movies.ToList();
            var data=from m in context.Details select new{m.Movie.Name,m.Actor,m.Role}; 
            return Ok(data);
        
  }
    [HttpGet]
    [Route("ListDetails/{id}")]
    public IActionResult Get(int id){
        if(id==null){
            return BadRequest("Id Cannot be Null");
        }
        var data=context.Details.Find(id);
        if(data==null){
            return NotFound($"Details for {id} not found");

        }
        return Ok(data);
}
[HttpPost]
[Route("AddDetails")]
public IActionResult Post(Detail d){
    
            context.Details.Add(d);
            context.SaveChanges();
    
    return Created("Details Added",d);
}
// [HttpPut]
// [Route("EditMovies/{id}")]
// public IActionResult Put(int id,Details d){
//     if(ModelState.IsValid){
//         Details details=context.Details.Find(id);
//         details.Actor=d.Actor;
//         details.
//     }
// }

}
}