using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Model
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public string? Date { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Amount { get; set; }

        public override string ToString()
        {
            return $"{Date} {Description} {Category} {Amount}";
        }
    }

}
