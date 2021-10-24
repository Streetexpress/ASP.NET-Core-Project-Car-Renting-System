using System.ComponentModel.DataAnnotations;

namespace CarRantingSystem.Models.Cars
{
    public class AddCarFormModel
    {
 
        public string Brand { get; init; }

        public string Model { get; init; }

        public string Description { get; init; }

        [Display(Name = "Image URL")]
        public string ImageURL { get; init; }

        public int Year { get; init; }

        public int CategoryId { get; init; }
    }
}
