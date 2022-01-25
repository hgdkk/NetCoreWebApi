using NetCoreWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.DataSource
{
    public class ApiDataSource
    {

        public static ApiDataSource current { get; } = new ApiDataSource();
        public List<Categories> categories { get; set; }
        
        public ApiDataSource()
        {
            categories = new List<Categories>()
            {
                new Categories()
                {
                    Id = 1,
                    Name = "Macera",
                    books = new List<Books>()
                    {
                        new Books()
                        {
                            Id = 1,
                            Name = "Da Vinci Şifresi",
                            Author = "Dan Brown"
                        },
                        new Books()
                        {
                            Id = 2,
                            Name = "Sil Baştan",
                            Author = "Ken Grimwood"
                        }
                    }
                },
                new Categories()
                {
                    Id = 2,
                    Name = "Korku",
                    books = new List<Books>()
                    {
                        new Books()
                        {
                            Id = 1,
                            Name = "Medyum",
                            Author = "Stephen King"
                        },
                        new Books()
                        {
                            Id = 2,
                            Name = "Hayvan Mezarlığı",
                            Author = "Stephen King"
                        }
                    }
                },
                new Categories()
                {
                    Id = 3,
                    Name = "Klasik",
                    books = new List<Books>()
                    {
                        new Books()
                        {
                            Id = 1,
                            Name = "Yeraltından Notlar",
                            Author = "Dostoyevski"
                        },
                        new Books()
                        {
                            Id = 2,
                            Name = "Dönüşüm",
                            Author = "Franz Kafka"
                        }
                    }
                }
            };

        }
    }
}
