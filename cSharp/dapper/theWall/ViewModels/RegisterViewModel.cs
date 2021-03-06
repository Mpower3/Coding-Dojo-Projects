using System.ComponentModel.DataAnnotations;

namespace theWall.ViewModels{
    public class RegisterViewModel{
        [Required(ErrorMessage = "You must include a first name.")]
        [MinLength(2, ErrorMessage = "First name must be filled in and at least 2 characters.")]
        public string fname {get; set;}
        [RequiredAttribute(ErrorMessage = "You must include a last name.")]
        [MinLengthAttribute(2, ErrorMessage = "Last name must be filled in and at least 2 characters.")]
        public string lname {get; set;}
        [Required(ErrorMessage = "You must include an email address.")]
        [EmailAddressAttribute(ErrorMessage = "Please use a valid email address.")]
        public string email {get; set;}
        [RequiredAttribute(ErrorMessage = "Please include a password.")]
        [DataTypeAttribute(DataType.Password)]
        [RegularExpressionAttribute(@"(?=^.{8,30}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;&quot;:;'?/&gt;.&lt;,]).*$", ErrorMessage = "Password must be 8 charactes long and contain at least 1 of each: uppercase letter, lowercase letter, number, and special character.")]
        public string password {get; set;}
        [DataTypeAttribute(DataType.Password)]
        [CompareAttribute("password", ErrorMessage = "Passwords must match")]
        public string passwordConfirmation {get; set;}
    }
}