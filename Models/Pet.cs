using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Pet_Hotel.Models
{
    public enum PetBreedType 
    {
        Sherpherd,
        Poodle,
        Beagle,
        Bulldog,
        Terrier,
        Boxer,
        Labrador,
        Retriever
    }
    public enum PetColorType 
    {
        White,
        Black,
        Golden,
        Tricolor,
        Spotted
    }

    public class Pet 
    {
        public int id {get; set;}
        [Required]
        public string name {get; set;}

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType petBreed {get; set;}

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType petColor {get; set;}

        public DateTime? checkedInAt {get; set;}

        [ForeignKey("petOwnerId")]
        public int petOwnerId {get; set;}
        public PetOwner petOwner;
    }
}
