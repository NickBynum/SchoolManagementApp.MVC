using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementApp.MVC.Data
{
    public class ClassMetdadata
    {
        [Display(Name ="Lecturer")]
        public int LecturerId { get; set; }

        [Display(Name ="Course")]
        public int CourseId{ get; set; }
    }
    [ModelMetadataType(type:typeof(ClassMetdadata))]
    public partial class Class { }
}
