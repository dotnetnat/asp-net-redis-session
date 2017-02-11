using Newtonsoft.Json;
using System;

namespace JsonAtttrSerialize.Models
{
    public abstract class Model
    {
        public int Id { get; set; }
    }
    [Serializable]
    //[JsonObject]
    public class UserModel:Model
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }
    [Serializable]
    //[JsonObject]
    public class Address
    {
        public int No { get; set; }
    }
}