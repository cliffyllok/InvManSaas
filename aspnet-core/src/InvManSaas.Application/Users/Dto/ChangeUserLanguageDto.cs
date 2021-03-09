using System.ComponentModel.DataAnnotations;

namespace InvManSaas.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}