using DeliveryWinForms.Controller;
using DeliveryWinForms.View;

namespace DeliveryWinForms;

/// <summary>
/// Главное меню управления БД
/// </summary>
public partial class MainFrom : Form
{
    public MainFrom()
    {
        InitializeComponent();
        comboBox1.SelectedIndex = 0;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ShowData();
    }

    /// <summary>
    /// Показывает данные выбранной таблицы
    /// </summary>
    private void ShowData()
    {
        var tableName = comboBox1.Text;
        switch (tableName)
        {
            case "Товар":
                ProductController.FillDataGridView(dataGridView);
                break;
            case "Заказ":
                OrderController.FillDataGridView(dataGridView);
                break;
            case "Отгрузка":
                ShipmentController.FillDataGridView(dataGridView);
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Переход на форму добавления товара
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonAddProduct_Click(object sender, EventArgs e)
    {
        var addProductForm = new AddProductForm();
        addProductForm.Owner = this;
        if (addProductForm.ShowDialog() == DialogResult.OK)
        {
            ShowData();
        }
    }

    /// <summary>
    /// Переход на форму добавления заказа
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonAddOrder_Click(object sender, EventArgs e)
    {
        var addOrderForm = new AddOrderForm();
        addOrderForm.Owner = this;
        if (addOrderForm.ShowDialog() == DialogResult.OK)
        {
            ShowData();
        }
    }

    /// <summary>
    /// Переход на форму добавления отгрузки
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonAddShipment_Click(object sender, EventArgs e)
    {
        var addShipmentForm = new AddShipmentForm();
        addShipmentForm.Owner = this;
        if (addShipmentForm.ShowDialog() == DialogResult.OK)
        {
            ShowData();
        }
    }
}
