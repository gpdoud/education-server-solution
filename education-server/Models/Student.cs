using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace education_server.Models {

    public class Student {

        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Lastname { get; set; }
        [StringLength(30)]
        public string Firstname { get; set; }
        [Range(400, 1600)]
        public int SAT { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 5.0)]
        public decimal GPA { get; set; }
        public bool InState { get; set; }

        public Student() {
            this.Id = 0;
            this.Lastname = string.Empty;
            this.Firstname = string.Empty;
            this.SAT = 0;
            this.GPA = 0;
            this.InState = true;
        }
    }
}
