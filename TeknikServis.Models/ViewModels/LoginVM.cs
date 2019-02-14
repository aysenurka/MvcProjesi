﻿using System.ComponentModel.DataAnnotations;

namespace TeknikServis.Models.ViewModels
{
    public class LoginVM
    {
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Şifreniz en az 5 karakter olmalıdır!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}