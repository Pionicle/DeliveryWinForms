using System.Data;
using DeliveryWinForms.Models;
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

    /// <summary>
    /// Добавляет новый товар в таблицу
    /// </summary>
    /// <param name="name"></param>
    /// <param name="price"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static void AddProduct(string name, string price)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException("Имя товара не может быть пустым.", nameof(name));
        }

        decimal cleanPrice;
        if (!decimal.TryParse(price, out cleanPrice))
        {
            throw new ArgumentException("Цена товара введена некорректно.", nameof(price));
        }   
        if (cleanPrice <= 0.0m)
        {
            throw new ArgumentException("Цена товара должна быть больше 0.", nameof(price));
        }

        using (var context = new ModelContext())
        {
            var productService = new ProductService(context);
            productService.Create(new Product
            {
                ProductName = name,
                ProductPrice = cleanPrice
            });
        }
    }

    /// <summary>
    /// Заполняет comboBox названием товара
    /// Заполняет список id товара
    /// </summary>
    /// <param name="comboBox"></param>
    /// <param name="idProduct"></param>
    public static void FillComboBox(ComboBox comboBox, List<int> idProduct)
    {
        using (var context = new ModelContext())
        {
            var productService = new ProductService(context);
            var products = productService.GetAll();
            foreach (var product in products)
            {
                idProduct.Add((int)product.ProductId);
                comboBox.Items.Add(product.ProductName);
            }
        }
    }
}