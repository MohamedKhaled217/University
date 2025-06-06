﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.DAL.Entity;

namespace Uni.BLL.ModelVM.Admin
{
    public class CreateStudentVM
    {
        [Key]
        //  public string SId { get; set; }
        public string FirstName { get; set; }
        public string MiddelName { get; set; }
        public string LastName { get; set; }
        // public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public string Address { get; set; }
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

    }
}
