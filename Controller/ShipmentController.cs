using DeliveryWinForms.Models;
using DeliveryWinForms.Services;
using System.Data;

namespace DeliveryWinForms.Controller;

/// <summary>
/// Контроллер отгрузок
/// </summary>
internal class ShipmentController
{
    /// <summary>
    /// Заполняет данными из таблицы Отгрузка
    /// </summary>
    /// <param name="dataGridView"></param>
    public static void FillDataGridView(DataGridView dataGridView)
    {
        var dataTable = new DataTable();
        dataTable.Columns.Add("Код отгрузки", typeof(int));
        dataTable.Columns.Add("Код заказа", typeof(int));
        dataTable.Columns.Add("Дата отгрузки", typeof(DateTime));
        dataTable.Columns.Add("Отгружено товара (шт.)", typeof(int));

        using (var context = new ModelContext())
        {
            var shipmentService = new ShipmentService(context);
            var shipments = shipmentService.GetAll();
            foreach (var shipment in shipments)
            {
                dataTable.Rows.Add(shipment.ShipmentId,
                                   shipment.OrderId,
                                   shipment.ShipmentDate,
                                   shipment.ShippedGoods);
            }
        }

        dataGridView.DataSource = dataTable;
    }

    /// <summary>
    /// Добавляет новую отгрузку в таблицу
    /// </summary>
    /// <param name="orderId"></param>
    /// <param name="shipmentDate"></param>
    /// <param name="shipmentGoods"></param>
    /// <exception cref="ArgumentException"></exception>
    public static void AddShipment(int orderId, string shipmentDate, string shipmentGoods)
    {
        int cleanShipmentGoods;
        if (!int.TryParse(shipmentGoods, out cleanShipmentGoods))
        {
            throw new ArgumentException("Отгружено товара введено некорректно.", nameof(shipmentGoods));
        }
        if (cleanShipmentGoods <= 0)
        {
            throw new ArgumentException("Отгружено товара должно быть больше 0.", nameof(shipmentGoods));
        }
        DateTime clearShipmentDate;
        if (!DateTime.TryParse(shipmentDate, out clearShipmentDate))
        {
            throw new ArgumentException("Дата отгрузки указана некорректно.", nameof(shipmentDate));
        }

        using (var context = new ModelContext())
        {
            var shipmentService = new ShipmentService(context);
            shipmentService.Create(new Shipment
            {
                OrderId = orderId,
                ShipmentDate = clearShipmentDate,
                ShippedGoods = cleanShipmentGoods
            });
        }
    }
}
