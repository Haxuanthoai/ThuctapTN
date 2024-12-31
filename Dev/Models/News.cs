using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("NEWS")]
public partial class News
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(10)]
    public string? Code { get; set; }

    [Column("TITLE")]
    [StringLength(200)]
    public string? Title { get; set; }

    [Column("DESCRIPTION")]
    public string? Description { get; set; }

    [Column("CONTENT", TypeName = "ntext")]
    public string? Content { get; set; }

    [Column("IMAGE")]
    public string? Image { get; set; }

    [Column("META_TITLE")]
    [StringLength(500)]
    public string? MetaTitle { get; set; }

    [Column("MAIN_KEYWORD")]
    [StringLength(500)]
    public string? MainKeyword { get; set; }

    [Column("META_KEYWORD")]
    [StringLength(500)]
    public string? MetaKeyword { get; set; }

    [Column("META_DESCRIPTION")]
    [StringLength(500)]
    public string? MetaDescription { get; set; }

    [Column("SLUG")]
    [StringLength(500)]
    public string? Slug { get; set; }

    [Column("VIEWS")]
    public int? Views { get; set; }

    [Column("LIKES")]
    public int? Likes { get; set; }

    [Column("STAR")]
    public double? Star { get; set; }

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
}
