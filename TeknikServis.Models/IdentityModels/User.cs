﻿using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace TeknikServis.Models.IdentityModels
{
    public class User : IdentityUser
    {
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(60)]
        [Required]
        public string Surname { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.Now;

        public string ActivationCode { get; set; }

        public string AvatarPath { get; set; }
    }
}
