using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Able.Models.Students
{
    public class Student
    {
        [Display(Name = "Id")]
        public string Id { get; set; }
       
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }


        [Display(Name = "Birth date")]
        public DateTime Birth { get; set; }

        [Display(Name = "Group")]
        public string Group { get; set; }
    }
}
