using APITestCesar.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITestCesar.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [Authorize]
        [HttpGet(Name = "Get")]
        public IEnumerable<PersonResponse> Get()
        {
            List<PersonResponse> persona = new List<PersonResponse>();
            for (int i = 0; i < 100; i++) 
            {
                persona.Add( new PersonResponse
                {
                    FirtsName = "Persona" + i,
                    LastName = "Apellido" + i
                });
            }
            return persona;
        }
    }
}
