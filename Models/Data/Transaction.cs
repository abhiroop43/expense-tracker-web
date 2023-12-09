using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models.Data
{

  public class Transaction
  {
    [Key]
    [Column(TypeName = "varchar(36)")]
    public string? TransactionId { get; set; } = Guid.NewGuid().ToString();

    // references the Category
    [Column(TypeName = "varchar(36)")]
    public required string CategoryId { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "nvarchar(255)")]
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }

    // navigational property for the Category
    public required Category Category { get; set; }
  }
}