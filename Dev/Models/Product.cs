using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("PRODUCT")]
public partial class Product
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CID")]
    public int? Cid { get; set; }

    [Column("CODE")]
    [StringLength(10)]
    public string? Code { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string? Title { get; set; }

    [Column("DESCRIPTION")]
    public string? Description { get; set; }

    [Column("CONTENT")]
    public string? Content { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    public string? Image { get; set; }

    [Column("META_TITLE")]
    [StringLength(500)]
    public string? MetaTitle { get; set; }

    [Column("META_KEYWORD")]
    [StringLength(500)]
    public string? MetaKeyword { get; set; }

    [Column("META_DESCRIPTION")]
    [StringLength(500)]
    public string? MetaDescription { get; set; }

    [Column("SLUG")]
    [StringLength(500)]
    public string? Slug { get; set; }

    [Column("PRICE_OLD", TypeName = "decimal(18, 0)")]
    public decimal? PriceOld { get; set; }

    [Column("PRICE_NEW", TypeName = "decimal(18, 0)")]
    public decimal? PriceNew { get; set; }

    [Column("SIZE")]
    [StringLength(500)]
    public string? Size { get; set; }

    [Column("VIEWS")]
    public int? Views { get; set; }

    [Column("LIKES")]
    public int? Likes { get; set; }

    [Column("STAR")]
    public double? Star { get; set; }

    [Column("HOME")]
    public byte? Home { get; set; }

    [Column("HOT")]
    public byte? Hot { get; set; }

    [Column("CREATED_DATE", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_DATE", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("ADMIN_CREATED")]
    [StringLength(255)]
    public string? AdminCreated { get; set; }

    [Column("ADMIN_UPDATED")]
    [StringLength(255)]
    public string? AdminUpdated { get; set; }

    [Column("STATUS")]
    public byte? Status { get; set; }

    [Column("ISDELETE")]
    public bool? Isdelete { get; set; }

    [InverseProperty("IdproductNavigation")]
    public virtual ICollection<OrdersDetail> OrdersDetails { get; set; } = new List<OrdersDetail>();
}
