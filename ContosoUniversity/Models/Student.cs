﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Imię nie może być dłuższe niż 50 znaków")]
        [Column("FirstName")]
        [Display(Name = "Imię")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Rekrutacji")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Imię i Nazwisko")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}