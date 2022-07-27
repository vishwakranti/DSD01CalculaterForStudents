using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace DSD01CalculaterForStudents.Pages
    [BindProperties]
{
    public class IndexModel : PageModel
    {
    [Display (Name = "FirstNumber")]

    [Display (Name = "SecondNumber")]


    [Display (Name = "Result") ]
        
        public double NumberA { get; set; }

        public double NumberB { get; set; }

        public double Result { get; set; }
        public void OnGet()
        {

        }
    public void OnPost()
        {

        }

    }
}