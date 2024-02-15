using System.Data;
using DeliveryWinForms.Services;

namespace DeliveryWinForms.Controller;

/// <summary>
/// Контроллер товаров
/// </summary>
internal class ProductController
{
    /// <summary>
    /// Заполняет данными из таблицы Товар
    /// </summary>
    /// <param name="dataGridView"></param>
    public static void FillDataGridView(DataGridView dataGridView)
    {
        var dataTable = new DataTable();
        dataTable.Columns.Add("Код товара", typeof(int));
        dataTable.Columns.Add("Наименование товара", typeof(string));
        dataTable.Columns.Add("Цена товара", typeof(decimal));

        using (var context = new ModelContext())
        {
            var productService = new ProductService(context);
            var products = productService.GetAll();
            foreach (var product in products)
            {
                dataTable.Rows.Add(product.ProductId,
                                   product.ProductName,
                                   product.ProductPrice);
            }
        }

        dataGridView.DataSource = dataTable;
    }
}