using DeliveryWinForms.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
