using System.ComponentModel.DataAnnotations;

public class Client
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name length can't exceed 100 characters")]
    public string Name { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Weight must be a positive number")]
    public decimal Weight { get; set; }

    [DataType(DataType.ImageUrl)]
    public string Photo { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime DateOfBirth { get; set; }
}
