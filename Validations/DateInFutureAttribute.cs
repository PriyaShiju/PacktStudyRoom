using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PacktStudyRoom.Models
{
    public class DateInFutureAttribute : ValidationAttribute
    {
        private readonly Func<DateTime> _datetimeprovider; // to use it as function or method

        public DateInFutureAttribute() : this(() => DateTime.Now)
        {
            
        }

        public DateInFutureAttribute( Func<DateTime> datetimeprovider)
        {
            this._datetimeprovider = datetimeprovider;
            ErrorMessage = "Date must be future date";
        }

        public override bool IsValid(object value)
        {
            bool isValid = false;
            if (value is DateTime date) { isValid = date > _datetimeprovider(); }
            return isValid;
        }
        
    }
}
