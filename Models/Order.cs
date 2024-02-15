namespace DeliveryWinForms.Models;

/// <summary>
/// Заказ
/// </summary>
public partial class Order
{
    #region Свойства
    /// <summary>
    /// Код заказа
    /// </summary>
    public int? OrderId { get; set; }

    /// <summary>
    /// Наименование заказа
    /// </summary>
    public string? OrderName { get; set; }

    /// <summary>
    /// Адрес заказчика
    /// </summary>
    public string? ClientAddress { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Номер контракта
    /// </summary>
    public string? ContractNumber { get; set; }

    /// <summary>
    /// Дата заключения
    /// </summary>
    public DateTime? DateConclusion { get; set; }

    /// <summary>
    /// Код продукта
    /// </summary>
    public int? ProductName { get; set; }

    /// <summary>
    /// Запланировано доставить
    /// </summary>
    public int? ScheduledDelivery { get; set; }

    /// <summary>
    /// Наименование продукта
    /// </summary>
    public virtual Product? ProductNameNavigation { get; set; }

    /// <summary>
    /// Связанные отгрузки
    /// </summary>
    public virtual ICollection<Shipment> Shipments { get; } = new List<Shipment>();
    #endregion
}
