using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CardGame.Models
{
    public class GamingCards
    {
        [Required]
        [DisplayName("Enter list of cards: ")]
        public string CardList { get; set; }
    }
}