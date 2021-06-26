using System.ComponentModel.DataAnnotations;

namespace BookInSession.Models
{
    public class BookViewModel
    {
        [Required(ErrorMessage = "kitabın ismi olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "kitabın yazarı olmalıdır.")]
        public string Author { get; set; }
        [Required(ErrorMessage = "kitabın yayın yılı olmalıdır.")]
        public int  PublishYear { get; set; }
        [Required(ErrorMessage = " kitabın kategorisi olmalıdır.")]
        public int CategoryId { get; set; }
    }
}