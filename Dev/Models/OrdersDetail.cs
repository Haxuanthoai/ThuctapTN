using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("ORDERS_DETAILS")]
public partial class OrdersDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("IDORD")]
    public int Idord { get; set; }

    [Column("IDPRODUCT")]
    public int Idproduct { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [Column("QTY")]
    public int Qty { get; set; }

    [Column("TOTAL", TypeName = "decimal(18, 2)")]
    public decimal? Total { get; set; }

    [Column("RETURN_QTY")]
    public int? ReturnQty { get; set; }

    [ForeignKey("Idord")]
    [InverseProperty("OrdersDetails")]
    public virtual Order IdordNavigation { get; set; } = null!;

    [ForeignKey("Idproduct")]
    [InverseProperty("OrdersDetails")]
    public virtual Product IdproductNavigation { get; set; } = null!;
}
