using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarHireWebApp.Areas.Identity.Data {
    // Add profile data for application users by adding properties to the CarHireWebAppUser class
    public class CarHireWebAppUser : IdentityUser, IValidatableObject {
        [PersonalData, Required]
        public string Name { get; set; }
        [PersonalData, Required, DataType(DataType.Date), Display(Name="Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        
        public DateTime RegistrationDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            DateTime now = DateTime.Now;
            int age = now.Year - DateOfBirth.Year;
            if (DateOfBirth > now.AddYears(-age)) age--; // Leap year correction
            if (age < 21) {
                yield return new ValidationResult("You must be over 21 to hire a car in the UK");
            }
        }
    }
}
