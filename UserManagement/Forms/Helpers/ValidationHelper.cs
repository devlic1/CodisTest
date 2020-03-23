using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Forms.Helpers
{
    public class ValidationHelper
    {
        /// <summary>
        /// Validation Helper method to validate model according to Data Annotation 
        /// and returns errorString of error messages
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="errorString"></param>
        /// <returns></returns>
        public static bool ValidateModel<T>(T model, out string errorString)
        {
            bool isValid = false;
            errorString = string.Empty;

            var validationContext = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            isValid = Validator.TryValidateObject(model, validationContext, results, true);

            if (!isValid)
            {
                StringBuilder sbErrors = new StringBuilder();

                foreach (var error in results)
                {
                    foreach (var member in error.MemberNames)
                    {
                        sbErrors.AppendLine(member);
                    }
                    sbErrors.AppendLine(error.ErrorMessage);
                    sbErrors.AppendLine();
                }

                errorString = sbErrors.ToString();
            }

            return isValid;
        }
    }
}
