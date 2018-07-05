using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Homework01Library
{
    public static class JsonHelper
    {

        public static IList<Person> GetDataFromJson()
        {
            var repo = new BlogRepository("../../Users.json");
            var persons = repo.GetAllPersons();
            return persons;
        }

        public static string Serialize<T>(T obj)
        {
            using (var stream = new MemoryStream())
            {
                var instance = Activator.CreateInstance<T>();
                var ser = new DataContractJsonSerializer(instance.GetType());
                ser.WriteObject(stream, obj);
                stream.Position = 0;
                var sr = new StreamReader(stream);
                return sr.ReadToEnd();
            }
        }

        public static T Deserialize<T>(string json)
        {
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                return (T)serializer.ReadObject(ms);
            }
        }
    }
}