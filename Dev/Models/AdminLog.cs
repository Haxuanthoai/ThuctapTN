using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("ADMIN_LOG")]
public partial class AdminLog
{
    [Key]
    [Column("LOG_ID")]
    public int LogId { get; set; }

    [Column("STATUS")]
    public int? Status { get; set; }

    [Column("SESSION_ID")]
    [StringLength(150)]
    public string? SessionId { get; set; }

    [Column("APP_CODE")]
    [StringLength(150)]
    public string? AppCode { get; set; }

    [Column("THREAD_ID")]
    [StringLength(150)]
    public string? ThreadId { get; set; }

    [Column("START_TIME", TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME", TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [Column("ADMIN_USER_ID")]
    public int? AdminUserId { get; set; }

    [Column("USER_LOGIN")]
    [StringLength(150)]
    public string? UserLogin { get; set; }

    [Column("USER_NAME")]
    [StringLength(250)]
    public string? UserName { get; set; }

    [Column("IP_ADDRESS")]
    [StringLength(50)]
    public string? IpAddress { get; set; }

    [Column("ACTION_CODE")]
    [StringLength(250)]
    public string? ActionCode { get; set; }

    [Column("ACTION_NAME")]
    [StringLength(250)]
    public string? ActionName { get; set; }

    [Column("MENU_CODE")]
    [StringLength(150)]
    public string? MenuCode { get; set; }

    [Column("MENU_NAME")]
    [StringLength(250)]
    public string? MenuName { get; set; }

    [Column("WEBPAGES_ACTION_ID")]
    public int? WebpagesActionId { get; set; }

    [Column("ACTION_TYPE")]
    public int? ActionType { get; set; }

    [Column("OBJECT_ID")]
    public int? ObjectId { get; set; }

    [Column("CONTENT")]
    public string? Content { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(550)]
    public string? Description { get; set; }

    [Column("LOG_LEVEL")]
    public int? LogLevel { get; set; }

    [Column("ERROR_CODE")]
    [StringLength(500)]
    public string? ErrorCode { get; set; }
}
