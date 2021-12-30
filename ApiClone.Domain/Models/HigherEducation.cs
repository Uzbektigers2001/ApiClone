using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Domain.Models
{
    public class HigherEducation
    {
        public bool success { get; set; } = true;
        public string code { get; set; } = "ok";
        public Data data { get; set; }
    }
   
    public class Data
    {
        public long Id { get; set; }

        [Column("PersonID")]
        public long PersonID { get; set; }

        [Column("ApplicationID")]
        public long ApplicationID { get; set; }

        [Column("EducationTypeName")]
        public string education_type_name { get; set; }

        [Column("EducationFormCode")]
        public int education_form_code { get; set; }

        [Column("EducationFormName")]
        public string education_form_name { get; set; }

        [Column("UniversityName")]
        public string university_name { get; set; }

        [Column("FacultyName")]
        public string faculty_name { get; set; }

        [Column("Course")]
        public string course { get; set; }

        [Column("EducationYear")]
        public string education_year { get; set; }
    }
    public class PersonHigherEducation
    {
        public long Id { get; set; }

        [Column("PersonID")]
        public long PersonID { get; set; }

        [Column("ApplicationID")]
        public long ApplicationID { get; set; }

        [Column("EducationTypeName")]
        public string education_type_name { get; set; }

        [Column("EducationFormCode")]
        public int education_form_code { get; set; }

        [Column("EducationFormName")]
        public string education_form_name { get; set; }

        [Column("UniversityName")]
        public string university_name { get; set; }

        [Column("FacultyName")]
        public string faculty_name { get; set; }

        [Column("Course")]
        public string course { get; set; }

        [Column("EducationYear")]
        public string education_year { get; set; }
    }
    [Keyless]
    public class GetPersonIdWithPinFLForApiClone
    {
        [Required]
        public long PersonID { get; set; }
    }
}
