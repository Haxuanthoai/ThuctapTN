using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

public partial class DevXuongMocContext : DbContext
{
    public DevXuongMocContext()
    {
    }

    public DevXuongMocContext(DbContextOptions<DevXuongMocContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminLog> AdminLogs { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Extension> Extensions { get; set; }

    public virtual DbSet<InforCompany> InforCompanies { get; set; }

    public virtual DbSet<Introduction> Introductions { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrdersDetail> OrdersDetails { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductExtension> ProductExtensions { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<ProductMaterial> ProductMaterials { get; set; }

    public virtual DbSet<Slide> Slides { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-THSARHS\\SQLEXPRESS;Database=DevXuongMoc;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__ADMIN_LO__4364C8826BF2E149");
        });

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ADMIN_US__3214EC2739901ACE");

            entity.Property(e => e.Salt).IsFixedLength();
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BANNER__3214EC274D7E8BD5");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCT___A88186B13985BFD1");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Isdelete).HasDefaultValue(false);
            entity.Property(e => e.Status).HasDefaultValue((byte)1);
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUSTOMER__3214EC27C51AF44F");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Isactive).HasDefaultValue(true);
            entity.Property(e => e.Isdelete).HasDefaultValue(false);
        });

        modelBuilder.Entity<Extension>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCT___EXTENSION");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Isdelete).HasDefaultValue(false);
            entity.Property(e => e.Status).HasDefaultValue((byte)1);
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Introduction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INTRODUC__3214EC2715DFAD94");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Image).HasDefaultValue("NO_IMAGE_AVAILABLE.jpg");
            entity.Property(e => e.Status).HasDefaultValue((byte)1);
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MATERIAL___EXTENSION");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NEWS__3214EC27E639B94D");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Image).HasDefaultValue("NO_IMAGE_AVAILABLE.jpg");
            entity.Property(e => e.Isdelete).HasDefaultValue(false);
            entity.Property(e => e.Status).HasDefaultValue((byte)1);
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORDERS__3214EC27561B5513");

            entity.Property(e => e.Isactive).HasDefaultValue(true);
            entity.Property(e => e.Isdelete).HasDefaultValue(false);
            entity.Property(e => e.OrdersDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdcustomerNavigation).WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ORDERS__IDCUSTOM__208CD6FA");
        });

        modelBuilder.Entity<OrdersDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORDERS_D__3214EC2778F35F8A");

            entity.Property(e => e.ReturnQty).HasDefaultValue(0);

            entity.HasOne(d => d.IdordNavigation).WithMany(p => p.OrdersDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ORDERS_DE__IDORD__245D67DE");

            entity.HasOne(d => d.IdproductNavigation).WithMany(p => p.OrdersDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ORDERS_DE__IDPRO__25518C17");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PARTNER__3214EC27355440A5");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Isdelete).HasDefaultValue(false);
            entity.Property(e => e.Logo).HasDefaultValue("NO_IMAGE_AVAILABLE.jpg");
            entity.Property(e => e.Orders).HasDefaultValue((byte)1);
            entity.Property(e => e.Status).HasDefaultValue((byte)1);
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCT__3214EC27E639B94D");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Home).HasDefaultValue((byte)0);
            entity.Property(e => e.Image).HasDefaultValue("NO_IMAGE_AVAILABLE.jpg");
            entity.Property(e => e.Isdelete).HasDefaultValue(false);
            entity.Property(e => e.Status).HasDefaultValue((byte)1);
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ProductExtension>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PRODUCTEXTENSIONS");
        });

        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PRODUCTIMAGES");
        });

        modelBuilder.Entity<ProductMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PRODUCTMATERIALS");
        });

        modelBuilder.Entity<Slide>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SLIDES__3214EC2789A8C9E9");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Image).HasDefaultValue("NO_IMAGE_AVAILABLE.jpg");
            entity.Property(e => e.Status).HasDefaultValue((byte)1);
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
