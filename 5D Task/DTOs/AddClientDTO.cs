namespace _5D_Task.DTOs
{
    public class ClientDTO
    {

        [StringLength(100, ErrorMessage = "Name length can't exceed 100 characters")]
        public string Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Weight must be a positive number")]
        public decimal Weight { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Photo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
    }
}
