using System.ComponentModel.DataAnnotations;

namespace sourcetree.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}