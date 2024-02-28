using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
	public class CreateNewUserDto
	{
		[Required(ErrorMessage ="Ad alanı zorunludur.")]
        public string Name { get; set; }


		[Required(ErrorMessage = "Soyad alanı zorunludur.")]
		public string Surname { get; set; }


		[Required(ErrorMessage = "Kullanıcı adı alanı zorunludur.")]
		public string Username { get; set; }


		[Required(ErrorMessage = "Mail alanı zorunludur.")]
		public string Mail { get; set; }


		[Required(ErrorMessage = "Şifre alanı zorunludur.")]
		public string Password { get; set; }


		[Required(ErrorMessage = "Şifre tekrar alanı zorunludur.")]
		[Compare("Password", ErrorMessage ="Şifreler uyuşmuyor.")]
		public string ConfirmPassword { get; set; }
	}
}
