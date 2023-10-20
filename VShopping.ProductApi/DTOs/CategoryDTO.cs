using System.ComponentModel.DataAnnotations;
using VShopping.ProductApi.Models;

namespace VShopping.ProductApi.DTOs;

public class CategoryDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = "The Name is Required")]
    [MinLength(3)]
    [MaxLength(100)]
    public string? Name { get; set; }

    public ICollection<Product>? Products { get; set; }
}
