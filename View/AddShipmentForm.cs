using DeliveryWinForms.Controller;

namespace DeliveryWinForms.View;

/// <summary>
/// Форма добавления Отгрузки
/// </summary>
public partial class AddShipmentForm : Form
{
    public AddShipmentForm()
    {
        InitializeComponent();
        DialogResult = DialogResult.Cancel;
        OrderController.FillComboBox(ordersComboBox);
        ordersComboBox.SelectedIndex = 0;
    }

    /// <summary>
    /// Отмена отгрузки
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Добавления отгрузки
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        int orderId = ordersComboBox.SelectedIndex;
        string shipmentDate = dateTimePicker.Value.ToShortDateString();
        string shipmentGoods = countTextBox.Text.Trim();
        try
        {
            ShipmentController.AddShipment(orderId, shipmentDate, shipmentGoods);
            DialogResult = DialogResult.OK;
            MessageTemplates.ShowInfoMessage("Товар добавлен.");
        }
        catch (Exception ex)
        {
            MessageTemplates.ShowErrorMessage(ex.Message);
        }
    }
}
