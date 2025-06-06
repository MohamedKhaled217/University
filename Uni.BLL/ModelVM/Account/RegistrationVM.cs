﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace Uni.BLL.ModelVM.Account
{
    public class RegistrationVM
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }


        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }
        public string NationalId { get; set; }




        public DateTime BirthDate { get; set; }
    }
}
