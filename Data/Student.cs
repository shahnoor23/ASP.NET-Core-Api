using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(350)")]
        public string FatherName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Address { get; set; }


       


    }
}
