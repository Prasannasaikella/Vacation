using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vacation.Models
{
    public class RegisterExternalModel
    {
        [Required(ErrorMessage = "Have to supply a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Have to supply an e-mail address")]
        public string Email { get; set; }
    }
}
