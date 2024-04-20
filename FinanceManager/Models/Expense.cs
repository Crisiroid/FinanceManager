using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FinanceManager.Models
{
    public class Expense
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [AllowNull]
        public string Description { get; set; }
    }
}
