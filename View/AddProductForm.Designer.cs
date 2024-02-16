namespace DeliveryWinForms.View
{
    partial class AddProductForm
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
            buttonAdd = new Button();
            buttonCancel = new Button();
            labelName = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(12, 128);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(147, 47);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 12F);
            buttonCancel.Location = new Point(235, 128);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(147, 47);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(12, 33);
            labelName.Name = "labelName";
            labelName.Size = new Size(117, 21);
            labelName.TabIndex = 6;
            labelName.Text = "Наименование";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 7;
            label1.Text = "Цена (руб.)";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(139, 30);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(243, 29);
            textBoxName.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 12F);
            textBoxPrice.Location = new Point(139, 82);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(243, 29);
            textBoxPrice.TabIndex = 9;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(398, 192);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(labelName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить продукт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonCancel;
        private Label labelName;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
    }
}