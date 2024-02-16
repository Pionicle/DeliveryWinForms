namespace DeliveryWinForms.View
{
    partial class AddOrderForm
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
            orderNameTextBox = new TextBox();
            labelName = new Label();
            buttonCancel = new Button();
            buttonAdd = new Button();
            addressTextBox = new TextBox();
            label1 = new Label();
            phoneTextBox = new TextBox();
            label2 = new Label();
            numberTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            countTextBox = new TextBox();
            label6 = new Label();
            dateTimePicker = new DateTimePicker();
            productComboBox = new ComboBox();
            SuspendLayout();
            // 
            // orderNameTextBox
            // 
            orderNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            orderNameTextBox.Location = new Point(240, 34);
            orderNameTextBox.Name = "orderNameTextBox";
            orderNameTextBox.Size = new Size(243, 29);
            orderNameTextBox.TabIndex = 14;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(25, 37);
            labelName.Name = "labelName";
            labelName.Size = new Size(193, 21);
            labelName.TabIndex = 12;
            labelName.Text = "Наименование заказчика";
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 12F);
            buttonCancel.Location = new Point(336, 301);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(147, 47);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(25, 301);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(147, 47);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addressTextBox.Location = new Point(240, 69);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(243, 29);
            addressTextBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(25, 72);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 15;
            label1.Text = "Адрес заказчика";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            phoneTextBox.Location = new Point(240, 104);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(243, 29);
            phoneTextBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(25, 107);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 17;
            label2.Text = "Телефон";
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberTextBox.Location = new Point(240, 139);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(243, 29);
            numberTextBox.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(25, 142);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 19;
            label3.Text = "Номер договора";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(25, 177);
            label4.Name = "label4";
            label4.Size = new Size(206, 21);
            label4.TabIndex = 21;
            label4.Text = "Дата заключения договора";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(25, 212);
            label5.Name = "label5";
            label5.Size = new Size(170, 21);
            label5.TabIndex = 23;
            label5.Text = "Наименование товара";
            // 
            // countTextBox
            // 
            countTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countTextBox.Location = new Point(240, 247);
            countTextBox.Name = "countTextBox";
            countTextBox.Size = new Size(243, 29);
            countTextBox.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(25, 247);
            label6.Name = "label6";
            label6.Size = new Size(184, 21);
            label6.TabIndex = 25;
            label6.Text = "Плановая поставка (шт.)";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(240, 174);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(243, 29);
            dateTimePicker.TabIndex = 27;
            // 
            // productComboBox
            // 
            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(240, 212);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(243, 29);
            productComboBox.TabIndex = 28;
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(502, 367);
            Controls.Add(productComboBox);
            Controls.Add(dateTimePicker);
            Controls.Add(countTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numberTextBox);
            Controls.Add(label3);
            Controls.Add(phoneTextBox);
            Controls.Add(label2);
            Controls.Add(addressTextBox);
            Controls.Add(label1);
            Controls.Add(orderNameTextBox);
            Controls.Add(labelName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Font = new Font("Segoe UI", 12F);
            Name = "AddOrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить заказ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox orderNameTextBox;
        private Label labelName;
        private Button buttonCancel;
        private Button buttonAdd;
        private TextBox addressTextBox;
        private Label label1;
        private TextBox phoneTextBox;
        private Label label2;
        private TextBox numberTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox countTextBox;
        private Label label6;
        private DateTimePicker dateTimePicker;
        private ComboBox productComboBox;
    }
}