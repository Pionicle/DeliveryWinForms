namespace DeliveryWinForms.Models;

/// <summary>
/// Отгрузка
/// </summary>
public partial class Shipment
{
    #region Свойства
    /// <summary>
    /// Код отгрузки
    /// </summary>
    public int? ShipmentId { get; set; }

    /// <summary>
    /// Код заказа
    /// </summary>
    public int? OrderId { get; set; }

    /// <summary>
    /// Дата отгрузки
    /// </summary>
    public DateTime? ShipmentDate { get; set; }

    /// <summary>
    /// Количество отгруженного товара 
    /// </summary>
    public int? ShippedGoods { get; set; }

    /// <summary>
    /// Заказ
    /// </summary>
    public virtual Order? Order { get; set; }
    #endregion
}
