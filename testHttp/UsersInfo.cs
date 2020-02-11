using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testHttp
{
    public class UsersInfo
    {
        [JsonIgnore]
        public int ID { get; set; }
        public List<Result> Results { get; set; }
        public Info Info { get; set; }
    }

    public class Result
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Gender { get; set; }
        public Name Name { get; set; }
        public Location Location { get; set; }
        public string Email { get; set; }
        public Login Login { get; set; }
        public Dob Dob { get; set; }
        public Registered Registered { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public Id id { get; set; }
        public Picture Picture { get; set; }
        public string Nat { get; set; }
    }
    public class Registered
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Date { get; set; }
      
        public int Age { get; set; }
    }
    public class Dob
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Date { get; set; }
        
        public int Age { get; set; }
    }
    public class Name
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Title { get; set; }      
        public string First { get; set; }
        public string Last { get; set; }
    }
    public class Location
    {
        [JsonIgnore]
        public int ID { get; set; }
        public Street Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public Coordinates Coordinates { get; set; }
        public Timezone Timezone { get; set; }
    }
    public class Coordinates
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
    public class Timezone
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Offset { get; set; }
        public string Description { get; set; }
    }
    public class Street
    {
        [JsonIgnore]
        public int ID { get; set; }
        public int Number { get; set; }
     
        public string Name { get; set; }
    }
    public class Login
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Uuid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }
    }
    public class Id
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Name { get; set; }
   
        public object Value { get; set; }
    }
    public class Picture
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Large { get; set; }
        public string Medium { get; set; }
        public string Thumbnail { get; set; }
    }
    public class Info
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Seed { get; set; }
        public int Results { get; set; }
        public int Page { get; set; }
        public string Version { get; set; }
    }

}
