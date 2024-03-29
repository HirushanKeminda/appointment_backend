﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class UserModel
    {
        [Key]
        [Column("UserId", TypeName = "nvarchar(36)")]
        public string Id { get; set; }


        [MaxLength(100)]
        [Column("UserName", TypeName = "varchar(100)")]
        public string Name { get; set; }

        [MaxLength(20)]
        [Column("UserContactNumber", TypeName = "nvarchar(20)")]
        public string contactNumber { get; set; }

        [MaxLength(100)]
        [Column("UserEmail", TypeName = "varchar(100)")]
        public string Email { get; set; }

        [MaxLength(1000)]
        [Column("UserMessage", TypeName = "varchar(1000)")]
        public string Message { get; set; }
    }
}
