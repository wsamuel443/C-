using Microsoft.AspNetCore.Mvc;

namespace NinhaAPI.Controllers
{   

    [ApiController]
    [Route("")]
    public class HelloController : ControllerBase{
        [HttpGet]

        public IActionResult Index(){
            return Ok(new {message = "Bem vindo!"});

        }
    }

    

    
        

}