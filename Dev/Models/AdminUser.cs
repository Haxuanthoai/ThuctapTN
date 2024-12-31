using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("ADMIN_USER")]
public partial class AdminUser
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACCOUNT")]
    [StringLength(200)]
    public string? Account { get; set; }

    [Column("PASSWORD")]
    [StringLength(200)]
    public string? Password { get; set; }

    [Column("MA_NHAN_SU")]
    public int? MaNhanSu { get; set; }

    [Column("NAME")]
    [StringLength(100)]
    public string? Name { get; set; }

    [Column("PHONE")]
    [StringLength(30)]
    public string? Phone { get; set; }

    [Column("EMAIL")]
    [StringLength(500)]
    public string? Email { get; set; }

    [Column("AVATAR")]
    [StringLength(200)]
    public string? Avatar { get; set; }

    [Column("ID_PHONG_BAN")]
    public int? IdPhongBan { get; set; }

    [Column("NGAY_TAO", TypeName = "datetime")]
    public DateTime? NgayTao { get; set; }

    [Column("NGUOI_TAO")]
    [StringLength(200)]
    public string? NguoiTao { get; set; }

    [Column("NGAY_CAP_NHAT", TypeName = "datetime")]
    public DateTime? NgayCapNhat { get; set; }

    [Column("NGUOI_CAP_NHAT")]
    [StringLength(200)]
    public string? NguoiCapNhat { get; set; }

    [Column("SESSION_TOKEN")]
    [StringLength(500)]
    public string? SessionToken { get; set; }

    [Column("SALT")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Salt { get; set; }

    [Column("IS_ADMIN")]
    public bool? IsAdmin { get; set; }

    [Column("TRANG_THAI")]
    public int? TrangThai { get; set; }

    [Column("IS_DELETE")]
    public bool? IsDelete { get; set; }
}
