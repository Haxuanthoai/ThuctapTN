using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("ORDERS")]
[Index("Idorders", Name = "UQ__ORDERS__99356D84E0043FF6", IsUnique = true)]
public partial class Order
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("IDORDERS")]
    [StringLength(100)]
    public string Idorders { get; set; } = null!;

    [Column("ORDERS_DATE", TypeName = "datetime")]
    public DateTime? OrdersDate { get; set; }

    [Column("IDCUSTOMER")]
    public int Idcustomer { get; set; }

    [Column("IDPAYMENT")]
    public int? Idpayment { get; set; }

    [Column("TOTAL_MONEY", TypeName = "decimal(18, 2)")]
    public decimal TotalMoney { get; set; }

    [Column("NOTES")]
    public string? Notes { get; set; }

    [Column("NAME_RECEIVER")]
    [StringLength(255)]
    public string? NameReceiver { get; set; }

    [Column("ADDRESS")]
    [StringLength(500)]
    public string? Address { get; set; }

    [Column("EMAIL")]
    [StringLength(255)]
    public string? Email { get; set; }

    [Column("PHONE")]
    [StringLength(15)]
    public string? Phone { get; set; }

    [Column("ISDELETE")]
    public bool? Isdelete { get; set; }

    [Column("ISACTIVE")]
    public bool? Isactive { get; set; }

    [ForeignKey("Idcustomer")]
    [InverseProperty("Orders")]
    public virtual Customer IdcustomerNavigation { get; set; } = null!;

    [InverseProperty("IdordNavigation")]
    public virtual ICollection<OrdersDetail> OrdersDetails { get; set; } = new List<OrdersDetail>();
}
