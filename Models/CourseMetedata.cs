using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementApp.MVC.Data
{
    public class CourseMetdadata
    {

    }
    [ModelMetadataType(type:typeof(CourseMetdadata))]
    public partial class Course { }
}
