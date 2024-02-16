using DeliveryWinForms.Controller;
using DeliveryWinForms.View;

namespace DeliveryWinForms;

/// <summary>
/// ������� ���� ���������� ��
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
    /// ���������� ������ ��������� �������
    /// </summary>
    private void ShowData()
    {
        var tableName = comboBox1.Text;
        switch (tableName)
        {
            case "�����":
                ProductController.FillDataGridView(dataGridView);
                break;
            case "�����":
                OrderController.FillDataGridView(dataGridView);
                break;
            case "��������":
                ShipmentController.FillDataGridView(dataGridView);
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// ������� �� ����� ���������� ������
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
    /// ������� �� ����� ���������� ������
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
    /// ������� �� ����� ���������� ��������
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
