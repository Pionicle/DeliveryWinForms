using DeliveryWinForms.Services;
using System.Data;

namespace DeliveryWinForms.Controller;

/// <summary>
/// Контроллер заказов
/// </summary>
internal class OrderController
{
    /// <summary>
    /// Заполняет данными из таблицы Заказ
    /// </summary>
    /// <param name="dataGridView"></param>
    public static void FillDataGridView(DataGridView dataGridView)
    {
        var dataTable = new DataTable();
        dataTable.Columns.Add("Код заказа", typeof(int));
        dataTable.Columns.Add("Наименование заказчика", typeof(string));
        dataTable.Columns.Add("Адрес заказчика", typeof(string));
        dataTable.Columns.Add("Телефон", typeof(string));
        dataTable.Columns.Add("Номер договора", typeof(string));
        dataTable.Columns.Add("Дата заключения договора", typeof(DateTime));
        dataTable.Columns.Add("Наименование товара", typeof(string));
        dataTable.Columns.Add("Плановая поставка (шт.)", typeof(int));

        using (var context = new ModelContext())
        {
            var orderService = new OrderService(context);
            var productService = new ProductService(context);
            var orders = orderService.GetAll();
            foreach (var order in orders)
            {
                dataTable.Rows.Add(order.OrderId,
                                   order.OrderName,
                                   order.ClientAddress,
                                   order.Phone,
                                   order.ContractNumber,
                                   order.DateConclusion,
                                   productService.GetById((int)order.ProductName).ProductName,
                                   order.ScheduledDelivery);
            }
        }

        dataGridView.DataSource = dataTable;
    }
}
