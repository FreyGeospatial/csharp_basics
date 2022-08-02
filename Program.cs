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
            Actors actors = new Actors { Actor1 = "John Wayne", Actor2 = "Jennifer Lopez"};
            string result = JsonConvert.SerializeObject(actors);
            Console.WriteLine(result);

            Console.WriteLine("\n\n Deserialization");
            Actors newActor = JsonConvert.DeserializeObject<Actors>(result);
            Console.WriteLine("Actor1 is : " + newActor.Actor2);
            Console.WriteLine("Actor2 is: " + newActor.Actor2);
            Console.WriteLine("\n\n");


        }
    }
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public Actors Actors { get; set; }
    }

    class Actors
    {   
        public string Actor1 { get; set; }
        public string Actor2 { get; set; }
    }
}