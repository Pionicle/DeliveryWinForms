using DeliveryWinForms.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryWinForms;

/// <summary>
/// Контекст
/// </summary>
public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Таблица Заказы
    /// </summary>
    public virtual DbSet<Order> Orders { get; set; }

    /// <summary>
    /// Таблица Товары
    /// </summary>
    public virtual DbSet<Product> Products { get; set; }

    /// <summary>
    /// Таблица Отгрузки
    /// </summary>
    public virtual DbSet<Shipment> Shipments { get; set; }
    
    /// <summary>
    /// Настройка БД
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseJet("data source=Поставка товаров.accdb");

    /// <summary>
    /// Модель БД
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PrimaryKey");

            entity.ToTable("Order");

            entity.Property(e => e.OrderId).HasColumnType("counter");
            entity.Property(e => e.ClientAddress).HasMaxLength(255);
            entity.Property(e => e.ContractNumber).HasMaxLength(255);
            entity.Property(e => e.OrderName).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.ScheduledDelivery).HasDefaultValueSql("0");

            entity.HasOne(d => d.ProductNameNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ProductName)
                .HasConstraintName("ТОВАРЗАКАЗ");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PrimaryKey");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId).HasColumnType("counter");
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductPrice)
                .HasDefaultValueSql("0")
                .HasColumnType("currency");
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.HasKey(e => e.ShipmentId).HasName("PrimaryKey");

            entity.ToTable("Shipment");

            entity.Property(e => e.ShipmentId).HasColumnType("counter");
            entity.Property(e => e.ShippedGoods).HasDefaultValueSql("0");

            entity.HasOne(d => d.Order).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("ЗАКАЗОТГРУЗКА");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
