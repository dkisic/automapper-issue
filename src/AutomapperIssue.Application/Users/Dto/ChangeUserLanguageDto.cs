using System.ComponentModel.DataAnnotations;

namespace AutomapperIssue.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}