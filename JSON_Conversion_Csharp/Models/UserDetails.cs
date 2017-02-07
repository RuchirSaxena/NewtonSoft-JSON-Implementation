using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSON_Conversion_Csharp.Models
{
    public class UserDetails
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Location { get; set; }
    } //{"UserId":1,"Username":"Ruchir Saxena","Location":"Noida"}
}