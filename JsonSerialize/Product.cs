using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonSerialize
{
    [Serializable]
    public class Product : ISerializable
    {
        public int Id { get;private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        static int counter = 0;
        public Product()
        {
            counter++;
            Id = counter;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id,typeof(Product));
            info.AddValue("Name", Name, typeof(Product));
            info.AddValue("Surnam", Surname, typeof(Product));
            info.AddValue("Position", Position, typeof(Product));
        }

        public override string? ToString()
        {
            return $"Id: {Id} Name: {Name} Surname: {Surname} Position: {Position}";
        }
    }
}
