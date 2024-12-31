using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("CUSTOMER")]
[Index("Username", Name = "UQ__CUSTOMER__B15BE12E1E04191F", IsUnique = true)]
public partial class Customer
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("NAME")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("USERNAME")]
    [StringLength(100)]
    public string Username { get; set; } = null!;

    [Column("PASSWORD")]
    [StringLength(255)]
    public string Password { get; set; } = null!;

    [Column("ADDRESS")]
    [StringLength(500)]
    public string? Address { get; set; }

    [Column("EMAIL")]
    [StringLength(255)]
    public string? Email { get; set; }

    [Column("PHONE")]
    [StringLength(15)]
    public string? Phone { get; set; }

    [Column("AVATAR")]
    [StringLength(255)]
    public string? Avatar { get; set; }

    [Column("CREATED_DATE", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_DATE", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string? CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string? UpdatedBy { get; set; }

    [Column("ISDELETE")]
    public bool? Isdelete { get; set; }

    [Column("ISACTIVE")]
    public bool? Isactive { get; set; }

    [InverseProperty("IdcustomerNavigation")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
