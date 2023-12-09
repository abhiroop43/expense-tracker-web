using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ExpenseTracker.Models.Enums;


namespace ExpenseTracker.Models.Data
{
  public class Category
  {
    [Key]
    [Column(TypeName = "varchar(36)")]
    public required string CategoryId { get; set; } = Guid.NewGuid().ToString();

    [Column(TypeName = "nvarchar(255)")]
    public required string Title { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string? Icon { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string Type { get; set; } = CategoryType.Expense;
  }
}