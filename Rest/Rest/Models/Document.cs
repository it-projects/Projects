using System.ComponentModel.DataAnnotations;

namespace Rest.Models
{
    public class Document
    {
        private string loginName = "ester";
        private string loginPassword = "ester";

        [Required(ErrorMessage = "Pole je povinné!")]
        [MaxLength(6, ErrorMessage = "Špatné jméno!")]
        public string LoginName { get { return loginName; } }

        [Required(ErrorMessage = "Pole je povinné!")]
        [MaxLength(6, ErrorMessage = "Špatné heslo!")]
        public string LoginPassword { get { return loginPassword; } }

        public string LoginEmail { get; set; }

        public bool predicate { get; set; }
    }
}