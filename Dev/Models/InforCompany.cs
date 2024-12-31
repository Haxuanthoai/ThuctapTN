using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("INFOR_COMPANY")]
public partial class InforCompany
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("NAME")]
    [StringLength(255)]
    public string? Name { get; set; }

    [Column("LOGO")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Logo { get; set; }

    [Column("PHONE")]
    [StringLength(255)]
    public string? Phone { get; set; }

    [Column("EMAIL")]
    [StringLength(255)]
    public string? Email { get; set; }

    [Column("ADDRESS")]
    [StringLength(255)]
    public string? Address { get; set; }

    [Column("YOUTUBE")]
    [StringLength(500)]
    public string? Youtube { get; set; }

    [Column("INSTAGRAM")]
    [StringLength(500)]
    public string? Instagram { get; set; }

    [Column("FACEBOOK")]
    [StringLength(500)]
    public string? Facebook { get; set; }

    [Column("CREATED_DATE")]
    public DateOnly? CreatedDate { get; set; }

    [Column("UPDATE_DATE")]
    public DateOnly? UpdateDate { get; set; }

    [Column("ADMIN_CREATED")]
    [StringLength(255)]
    public string? AdminCreated { get; set; }

    [Column("ADMIN_UPDATED")]
    [StringLength(255)]
    public string? AdminUpdated { get; set; }

    [Column("META_TITLE")]
    [StringLength(500)]
    public string? MetaTitle { get; set; }

    [Column("META_KEYWORD")]
    [StringLength(500)]
    public string? MetaKeyword { get; set; }

    [Column("META_DESCRIPTION")]
    [StringLength(500)]
    public string? MetaDescription { get; set; }
}
