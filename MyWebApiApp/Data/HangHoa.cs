using System.ComponentModel.DataAnnotations;

namespace MyWebApiApp.Data
{
    public class HangHoa
    {
        [Key]
        public Guid MaHH { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenHH { get; set; }  
        public string MoTa { get; set; }
        [Range(0, Double.MaxValue)]
        public double DonGia { get; set; }  
        public byte GiamGia { get; set; }   
    }
}
