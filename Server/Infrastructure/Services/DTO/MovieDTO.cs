using System;
using System.Net.Http;

namespace Infrastructure.Services.DTO
{
    public class MovieDTO
    {
        public string id { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public double nota { get; set; }
    }
}
