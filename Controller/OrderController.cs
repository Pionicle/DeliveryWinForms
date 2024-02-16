using DeliveryWinForms.Services;
using System.Data;
using DeliveryWinForms.Models;

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

    /// <summary>
    /// Добавляет заказ
    /// </summary>
    /// <param name="orderName"></param>
    /// <param name="clientAddress"></param>
    /// <param name="phone"></param>
    /// <param name="contractNumber"></param>
    /// <param name="dateConclusion"></param>
    /// <param name="productId"></param>
    /// <param name="scheduledDelivery"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static void AddOrder(string orderName,
                                string clientAddress,
                                string phone,
                                string contractNumber,
                                string dateConclusion,
                                int productId,
                                string scheduledDelivery)
    {
        if (string.IsNullOrEmpty(orderName))
        {
            throw new ArgumentNullException("Наименование заказчика не может быть пустым.", nameof(orderName));
        }
        if (string.IsNullOrEmpty(clientAddress))
        {
            throw new ArgumentNullException("Адрес заказчика не может быть пустым.", nameof(clientAddress));
        }
        if (string.IsNullOrEmpty(phone))
        {
            throw new ArgumentNullException("Телефон не может быть пустым.", nameof(phone));
        }
        if (string.IsNullOrEmpty(contractNumber))
        {
            throw new ArgumentNullException("Номер договора не может быть пустым.", nameof(contractNumber));
        }

        int clearScheduledDelivery;
        if (!int.TryParse(scheduledDelivery, out clearScheduledDelivery))
        {
            throw new ArgumentException("Плановая поставка указана некорректно.", nameof(dateConclusion));
        }
        if (clearScheduledDelivery <= 0)
        {
            throw new ArgumentException("Плановая поставка должна быть больше 0.", nameof(scheduledDelivery));
        }
        DateTime clearDateConclusion;
        if (!DateTime.TryParse(dateConclusion,out clearDateConclusion))
        {
            throw new ArgumentException("Дата заключения договора указана некорректно.", nameof(dateConclusion));
        }

        using (var context = new ModelContext())
        {
            var orderService = new OrderService(context);
            orderService.Create(new Order{
                OrderName = orderName,
                ClientAddress = clientAddress,
                Phone = phone,
                ContractNumber = contractNumber,
                DateConclusion = clearDateConclusion,
                ProductName = productId,
                ScheduledDelivery = clearScheduledDelivery
            });
        }
    }

    /// <summary>
    /// Заполняет comboBox id заказа
    /// </summary>
    /// <param name="comboBox"></param>
    /// <param name="idOrder"></param>
    public static void FillComboBox(ComboBox comboBox)
    {
        using (var context = new ModelContext())
        {
            var orderService = new OrderService(context);
            var orders = orderService.GetAll();
            foreach (var order in orders)
            {
                comboBox.Items.Add(order.OrderId);
            }
        }
    }
}
