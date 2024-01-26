using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ServiceTypeModel
    {
        [Key]
        [Column("TypeId", TypeName = "nvarchar(36)")]
        public required string Id { get; set; }


        [MaxLength(50)]
        [Column("TypeName", TypeName = "varchar(50)")]
        public required string Name { get; set; }

        [MaxLength(200)]
        [Column("Description", TypeName = "varchar(200)")]
        public string Description { get; set; }


        public virtual ICollection<AppointmentModel> Appointments { get; set; }
    }
}
