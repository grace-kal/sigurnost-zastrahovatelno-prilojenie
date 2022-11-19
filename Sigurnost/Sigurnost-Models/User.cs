using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _typeStrings = Sigurnost_Models.TypeStrings;

namespace Sigurnost_Models
{
    public class User : IdentityUser
    {
        //public User(IEnumerable<Article> userArticles,
        //    IEnumerable<InsuranceContract> boughtInsuranceContracts,
        //    IEnumerable<InsuranceContract> soldInsuranceContracts)
        //{
        //    UserArticles = userArticles;
        //    BoughtInsuranceContracts = boughtInsuranceContracts;
        //    SoldInsuranceContracts = soldInsuranceContracts;
        //}

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string CurrentAddress { get; set; }

        [Required]
        public string Citizenship { get; set; }

        [Required]
        public string PlaceOfBirth { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public uint EGN { get; set; }

        public bool Sex { get; set; }

        [Required]
        public string WorkIndustry { get; set; }

        [Required]
        public string WorkPlace { get; set; }

        public virtual IEnumerable<Article> UserArticles { get; set; }
        public virtual IEnumerable<InsuranceContract> BoughtInsuranceContracts { get; set; }
        public virtual IEnumerable<InsuranceContract> SoldInsuranceContracts { get; set; }

    }
}
