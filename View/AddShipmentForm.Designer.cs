namespace DeliveryWinForms.View
{
    partial class AddShipmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCancel = new Button();
            buttonAdd = new Button();
            dateTimePicker = new DateTimePicker();
            countTextBox = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            ordersComboBox = new ComboBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 12F);
            buttonCancel.Location = new Point(241, 126);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(147, 47);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(12, 126);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(147, 47);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(198, 47);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(190, 29);
            dateTimePicker.TabIndex = 33;
            // 
            // countTextBox
            // 
            countTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countTextBox.Location = new Point(198, 82);
            countTextBox.Name = "countTextBox";
            countTextBox.Size = new Size(190, 29);
            countTextBox.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 82);
            label6.Name = "label6";
            label6.Size = new Size(180, 21);
            label6.TabIndex = 31;
            label6.Text = "Отгружено товара (шт.)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 47);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 30;
            label4.Text = "Дата отгрузки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 15);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 28;
            label3.Text = "Код заказа";
            // 
            // ordersComboBox
            // 
            ordersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ordersComboBox.FormattingEnabled = true;
            ordersComboBox.Location = new Point(198, 12);
            ordersComboBox.Name = "ordersComboBox";
            ordersComboBox.Size = new Size(190, 29);
            ordersComboBox.TabIndex = 34;
            // 
            // AddShipmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(406, 188);
            Controls.Add(ordersComboBox);
            Controls.Add(dateTimePicker);
            Controls.Add(countTextBox);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "AddShipmentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить отгрузку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonAdd;
        private DateTimePicker dateTimePicker;
        private TextBox countTextBox;
        private Label label6;
        private Label label4;
        private Label label3;
        private ComboBox ordersComboBox;
    }
}