using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApi.DataSource;

namespace NetCoreWebApi
{
    [Route("api/books")]
    public class BooksController : Controller
    {
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(ApiDataSource.current.categories);
        }

        [HttpGet("{Id}")]
        public IActionResult GetCategories(int id)
        {
            var data = ApiDataSource.current.categories.FirstOrDefault(x => x.Id == id);
            if (data == null)
                return NotFound();
            return Ok(data);
        }

        [HttpGet("author/{Name}")]
        public IActionResult GetAuthor(string name)
        {
            var data = ApiDataSource.current.categories.SelectMany(x => x.books.Select(i => new {i.Id,i.Name,i.Author }).Where(a => a.Author == name)).ToList();
            if (data == null)
                return NotFound();
            return Ok(data);
        }
    }
}