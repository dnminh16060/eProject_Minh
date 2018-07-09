//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_eProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profile()
        {
            this.Tickets = new HashSet<Ticket>();
        }
    
        public long ID { get; set; }

        [Required]
        [Display(Name ="UserName")]
        [MaxLength(16, ErrorMessage = "UserName must be less than 16 characters")]
        [MinLength(6, ErrorMessage = "UserName must be at least 6 characters long")]
        public string UserID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(32, ErrorMessage = "Password must be less than 32 characters")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Enter only alphabets")]
        [MaxLength(20, ErrorMessage = "FirstName must be less than 20 characters")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Enter only alphabets")]
        [MaxLength(20, ErrorMessage = "LastName must be less than 20 characters")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "LastName must be less than 100 characters")]
        public string Address { get; set; }

        [Required]
        [RegularExpression("^(01[2689]|09)[0-9]{8}$", ErrorMessage = "Invalid PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid EmailAddress")]
        public string EmailAddress { get; set; }

        [Required]
        public bool Sex { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [MaxLength(16, ErrorMessage = "CreditCard must be less than 16 characters")]
        public string CreditCard { get; set; }

        public int SkyMiles { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
        
    }
}
