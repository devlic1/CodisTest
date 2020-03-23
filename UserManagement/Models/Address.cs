using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Constants;

namespace UserManagement.Models
{
    public class Address
    {
        public Guid PrimaryKey { get; set; }

        [Required]
        public string Line1 { get; set; }

        [RegularExpression(RegexConstant.NoNumberAllowed,
             ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "NoNumbersAllowed")]
        public string Line2 { get; set; }

        //[RegularExpression(Constants.Common.Countries, ErrorMessage = "Invalid Country.")]
        public string Country { get; set; }

        [RegularExpression(RegexConstant.NoSymboldSpecialCharactersAllowed,
             ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "NoSpecialChactersAndSymbols")]
        public string PostCode { get; set; }
    }
}
