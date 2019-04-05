using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestfulApi.Entities;
using RestfulApi.IRepository;

namespace RestfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrariesController : ControllerBase
    {
       
            private readonly ILibraryRepository<Author> _libraryRepository;

            public LibrariesController(ILibraryRepository<Author> libraryRepository)
            {
                _libraryRepository = libraryRepository;
            }

            // GET: api/Libraries/GetAllAuthor  
            [HttpGet]
            [Route("GetAllAuthor")]
            public IActionResult GetAllAuthor()
            {
            try
            {
                IEnumerable<Author> authors = _libraryRepository.GetAllAuthor();
                return Ok(authors);
            }
            catch
            {
                return StatusCode(500);
            }
                
            }

        }

    
}