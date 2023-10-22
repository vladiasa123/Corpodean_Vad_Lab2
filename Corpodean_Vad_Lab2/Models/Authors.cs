using System.ComponentModel.DataAnnotations;

namespace Corpodean_Vad_Lab2.Models
{
    public class Authors
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
