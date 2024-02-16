using DeliveryWinForms.Controller;

namespace DeliveryWinForms.View;

/// <summary>
/// Форма добавления заказа
/// </summary>
public partial class AddOrderForm : Form
{
    /// <summary>
    /// Хранит id товаров
    /// </summary>
    private List<int> idProduct = new List<int>();
    public AddOrderForm()
    {
        InitializeComponent();
        ProductController.FillComboBox(productComboBox, idProduct);
        productComboBox.SelectedIndex = 0;
        DialogResult = DialogResult.Cancel;
    }

    /// <summary>
    /// Отмена заказа
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Добавление заказа
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        string orderName = orderNameTextBox.Text.Trim();
        string clientAddress = addressTextBox.Text.Trim();
        string phone = phoneTextBox.Text.Trim();
        string contractNumber = numberTextBox.Text.Trim();
        string dateConclusion = dateTimePicker.Value.ToShortDateString();
        int productId = productComboBox.SelectedIndex;
        string scheduledDelivery = countTextBox.Text.Trim();
        try
        {
            OrderController.AddOrder(orderName,
                                     clientAddress,
                                     phone,
                                     contractNumber,
                                     dateConclusion,
                                     productId,
                                     scheduledDelivery);
            DialogResult = DialogResult.OK;
            MessageTemplates.ShowInfoMessage("Заказ добавлен.");
        }
        catch (Exception ex)
        {
            MessageTemplates.ShowErrorMessage(ex.Message);
        }
    }
}
