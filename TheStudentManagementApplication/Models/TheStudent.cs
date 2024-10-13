using System.ComponentModel.DataAnnotations;

namespace TheStudentManagementApplication.Models
{

    //This is the model for Student

    public class TheStudent
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required (ErrorMessage = "Index Number is required !")]
        public int? IndexNumber { get; set; }

        [Required (ErrorMessage = "First Name is required !")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Last Name is required !")]
        public string LastName { get; set; }

        [Required (ErrorMessage = "Class Room is required !")]
        public string ClassRoom { get; set; }

        [Required (ErrorMessage = "Telephone Number is required !")]
        public string TeleNumber { get; set; }

        [Required (ErrorMessage = "Address No. is required !")]
        public string AddressNumber { get; set; }

        [Required (ErrorMessage = "Address Road is required !")]
        public string AddressRoad { get; set; }

        [Required(ErrorMessage = "Address City is required !")]
        public string AddressCity { get; set; }

        public bool IsActive { get; set; }


        public string FullAddress
        {
            get
            {
                return $"{AddressNumber} , {AddressRoad} , {AddressCity}";
            }

        }

        public string IsActiveAnswer
        {
            get
            {
                if (IsActive == true)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }

            }
        }
    }
}
