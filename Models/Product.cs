namespace DeliveryWinForms.Models;

/// <summary>
/// Товар
/// </summary>
public partial class Product
{
    #region Свойства
    /// <summary>
    /// Код товара
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Наименование товара
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// Цена товара
    /// </summary>
    public decimal? ProductPrice { get; set; }

    /// <summary>
    /// Связанные заказы
    /// </summary>
    public virtual ICollection<Order> Orders { get; } = new List<Order>();
    #endregion
}
