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
        public string petBreed {get; set;}

        [Required]
        public string petColor {get; set;}

        public DateTime checkedInAt {get; set;}

        [ForeignKey("petOwner")]
        public int petOwnerId {get; set;}
        public PetOwner petOwner;
    }
}
