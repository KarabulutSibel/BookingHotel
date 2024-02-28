﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
	public class LoginUserDto
	{
        [Required(ErrorMessage ="Kullanıcı adını giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Şifrenizi giriniz.")]
        public string Password { get; set; }
    }
}
