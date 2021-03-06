using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{

    public enum PetBreedType {}
    public enum PetColorType {}

    // Set up 'Pet' class attributes
    public class Pet{
        public int id {get; set;}
        [Required]
        public string name {get; set;}
        [Required]
        public string Breed {get; set;}
        [Required]
        public string Color {get; set;}
        public DateTime? checkedInAt {get; set;} 
        public PetOwner petOwner {get; set;}//sets up foreign key for petOwnerid
        public int petOwnerid {get; set;}//send in the petOwnerid so we do not have to send in an entire PetOwner
            
        public void checkIn()
        {
            // We believe this should work due to research at 'dotnetperls'
            this.checkedInAt = DateTime.UtcNow;
        }//move on to set up controllers

        public void checkOut()
        {
            this.checkedInAt = null;
        }
    }
}
