using System.ComponentModel.DataAnnotations;


namespace Rest.Models
{
    public class Document
    {
        public string HeadTitle { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public string Name { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Ico { get; set; }

        [Required(ErrorMessage ="Pole je povinné!")]
        [MaxLength(6,ErrorMessage ="Špatné jméno!")]
        public string LoginName { get; set; }

        [Required(ErrorMessage ="Pole je povinné!")]
        [MaxLength(6, ErrorMessage ="Špatné heslo!")]
        public string LoginPassword { get; set; }

        public string LoginEmail { get; set; }
    }
}