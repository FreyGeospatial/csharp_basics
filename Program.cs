using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONSerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialization");
            Movie movie = new Movie { Id = 1, Title = "Mission Impossible" };
            string result = JsonConvert.SerializeObject(movie);
            Console.WriteLine(result);

            Console.WriteLine("\n\n Deserialization");
            Movie newMovie = JsonConvert.DeserializeObject<Movie>(result);
            Console.WriteLine("Id is : " + newMovie.Id);
            Console.WriteLine("Title is: " + newMovie.Title);
            Console.WriteLine("\n\n");
        }
    }
    class Movie
    {
        public int Id { get; set; }
        public string Title {get; set; }
    }
}