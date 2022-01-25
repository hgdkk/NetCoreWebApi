using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Model
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfBooks { get { return books.Count; } }
        public List<Books> books { get; set; } = new List<Books>();
    }
}
