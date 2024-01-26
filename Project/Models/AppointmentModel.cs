using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class AppointmentModel
    {
        [Key]
        [Column("AppointmentId", TypeName = "nvarchar(36)")]
        public int Id { get; set; }

        [MaxLength(50)]
        [Column("ServiceTypeName", TypeName = "nvarchar(50)")]
        public required string TypeName { get; set; }
        public ServiceTypeModel ServiceType { get; set; }

        

        public DateTime DateTime { get; set; }



        [MaxLength(100)]
        [Column("CustomerName", TypeName = "nvarchar(100)")]
        public required string name { get; set; }


        [MaxLength(20)]
        [Column("ContactNumber", TypeName = "nvarchar(20)")]
        public required string contactNumber { get; set; }


        [MaxLength(200)]
        [Column("Email", TypeName = "varchar(200)")]
        public required string Email { get; set; }



    }
}
