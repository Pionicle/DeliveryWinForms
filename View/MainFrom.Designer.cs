namespace DeliveryWinForms
{
    partial class MainFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            buttonAddProduct = new Button();
            buttonAddOrder = new Button();
            buttonAddShipment = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 58);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(776, 380);
            dataGridView.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.Items.AddRange(new object[] { "Товар", "Заказ", "Отгрузка" });
            comboBox1.Location = new Point(88, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 29);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 2;
            label1.Text = "Таблица";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Font = new Font("Segoe UI", 12F);
            buttonAddProduct.Location = new Point(302, 12);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(147, 40);
            buttonAddProduct.TabIndex = 3;
            buttonAddProduct.Text = "Добавить товар";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.Font = new Font("Segoe UI", 12F);
            buttonAddOrder.Location = new Point(455, 10);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(147, 40);
            buttonAddOrder.TabIndex = 4;
            buttonAddOrder.Text = "Добавить заказ";
            buttonAddOrder.UseVisualStyleBackColor = true;
            buttonAddOrder.Click += buttonAddOrder_Click;
            // 
            // buttonAddShipment
            // 
            buttonAddShipment.Font = new Font("Segoe UI", 12F);
            buttonAddShipment.Location = new Point(608, 10);
            buttonAddShipment.Name = "buttonAddShipment";
            buttonAddShipment.Size = new Size(156, 40);
            buttonAddShipment.TabIndex = 5;
            buttonAddShipment.Text = "Добавить отгрузку";
            buttonAddShipment.UseVisualStyleBackColor = true;
            buttonAddShipment.Click += buttonAddShipment_Click;
            // 
            // MainFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddShipment);
            Controls.Add(buttonAddOrder);
            Controls.Add(buttonAddProduct);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView);
            Name = "MainFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Работа с поставками";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private ComboBox comboBox1;
        private Label label1;
        private Button buttonAddProduct;
        private Button buttonAddOrder;
        private Button buttonAddShipment;
    }
}
