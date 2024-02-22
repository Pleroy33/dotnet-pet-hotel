using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Hotel.Models
{
    public class PetOwner // ? Camel-case?
    {
        public int id {get; set;}

        [Required]
        public string name {get; set;}

        [Required]
        public string emailAddress {get; set;}

        public int petCount = 0;
    }
}
