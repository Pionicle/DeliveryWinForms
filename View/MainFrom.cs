using DeliveryWinForms.Controller;

namespace DeliveryWinForms
{
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
    }
}
