using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementApp.MVC.Data
{
    public class StudentMetadata
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
    }
    [ModelMetadataType(type:typeof(StudentMetadata))]
    public partial class Student { }
}
