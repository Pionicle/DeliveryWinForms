using DeliveryWinForms.Controller;

namespace DeliveryWinForms.View;

/// <summary>
/// Форма добавления товара
/// </summary>
public partial class AddProductForm : Form
{
    public AddProductForm()
    {
        InitializeComponent();
        DialogResult = DialogResult.Cancel;
    }

    /// <summary>
    /// Добавление товара
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        var name = textBoxName.Text.Trim();
        var price = textBoxPrice.Text.Trim();
        try
        {
            ProductController.AddProduct(name, price);
            DialogResult = DialogResult.OK;
            MessageTemplates.ShowInfoMessage("Товар добавлен.");
        }
        catch (Exception ex)
        {
            MessageTemplates.ShowErrorMessage(ex.Message);
        }
    }

    /// <summary>
    /// Отмена товара
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
