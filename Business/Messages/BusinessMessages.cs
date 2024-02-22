using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Messages
{
    public class BusinessMessages
    {
        public static string NationalIdentityLenght = "TC kimlik Numarası 11 rakamdan az veya daha fazla olamaz";
        public static string EmailIsInvalid = "Geçersiz bir mail adresi girdiniz";
        public static string PasswordIsInvalid = "Geçersiz şifre";
        public static string PhoneNumberIsValid = "Telefon formatı geçersizdir";
        public static string SocialMediaLimit = "En fazla 3 adet hesap eklenebilir";
        public static string LanguageUnique = "Seçilen dil bir daha eklenemez";
        public static string SameSkill = "Aynı yetkinlikten ekleyemezsiniz!";
    }
}
