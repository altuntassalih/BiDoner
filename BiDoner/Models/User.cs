using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiDoner.Models
{
    public class User
    {
        [Required(ErrorMessage = "Lütfen Bir Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Bir Şifre Giriniz")]
        public string Password { get; set; }
    }
}