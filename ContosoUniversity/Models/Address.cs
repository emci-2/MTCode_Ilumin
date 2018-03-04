using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public abstract class Address
    {
        [EmailAddress]
        [RegularExpression("[a-zA-Z0-9._]+@contoso.edu$", ErrorMessage = "The Email must be a valid Contoso University email.")]
        public string Email { get; set; }
    }
}