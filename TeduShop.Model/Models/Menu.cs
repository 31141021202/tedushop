using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public int GroupID { get; set; }

        [ForeignKey("GroupID")] // Tên trường mà GroupID ở trên sẽ trỏ đến trong bảng MenuGroup. Bên Menu Group cần có một IEnumeable<Menu>
        public virtual MenuGroup MenuGroup { get; set; }

        [StringLength(50)]
        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
