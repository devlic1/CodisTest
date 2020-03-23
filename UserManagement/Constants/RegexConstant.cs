using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Constants
{
    class RegexConstant
    {
        public const string NoNumberAllowed = @"^([^0-9]*)$";

        public const string NoSymboldSpecialCharactersAllowed= @"^[_A-z0-9]*((-|\s)*[_A-z0-9])*$";
    }
}
