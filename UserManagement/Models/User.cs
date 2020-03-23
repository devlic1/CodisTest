using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Constants;

namespace UserManagement.Models
{
    public class User
    {
        public Guid PrimaryKey { get; set; }

        [Required]
        [RegularExpression(RegexConstant.NoNumberAllowed,
             ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "NoNumbersAllowed")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(RegexConstant.NoNumberAllowed,
             ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "NoNumbersAllowed")]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [RegularExpression(RegexConstant.NoNumberAllowed,
             ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "NoNumbersAllowed")]
        public string NickName { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
