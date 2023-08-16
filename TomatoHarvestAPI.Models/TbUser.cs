using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TomatoHarvestAPI.Models
{
    public class TbUser
    {
        [Key]
        [ValidateNever]
        public int UserId { get; set; }

        [Required(ErrorMessage = "User Name is required.")]
        [RegularExpression("^[a-zA-Z0-9]*$")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "User Namer must be between 3 and 50 characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 20 characters.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[\\W_])[A-Za-z\\d\\W_]{8,20}$")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "Email  must be less than 50 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required.")]
        //[RegularExpression("^[0-9]{10}$")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Phone must be between 9 and 50 characters.")]
        public string Phone { get; set; }

        [Required]
        public int CurrentState { get; set; } = 1;
    }
}
