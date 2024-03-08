namespace DemkaFinal
{
    partial class Product
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureOfProduct = new PictureBox();
            labelProductType = new Label();
            labelProductName = new Label();
            labelProductArtc = new Label();
            labelProductMaterials = new Label();
            labelProductLine = new Label();
            labelProductCost = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureOfProduct).BeginInit();
            SuspendLayout();
            // 
            // pictureOfProduct
            // 
            pictureOfProduct.Location = new Point(11, 17);
            pictureOfProduct.Name = "pictureOfProduct";
            pictureOfProduct.Size = new Size(109, 76);
            pictureOfProduct.TabIndex = 0;
            pictureOfProduct.TabStop = false;
            // 
            // labelProductType
            // 
            labelProductType.AutoSize = true;
            labelProductType.Font = new Font("Segoe UI", 11F);
            labelProductType.Location = new Point(148, 17);
            labelProductType.Name = "labelProductType";
            labelProductType.Size = new Size(102, 20);
            labelProductType.TabIndex = 1;
            labelProductType.Text = "Тип продукта";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 11F);
            labelProductName.Location = new Point(256, 17);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(183, 20);
            labelProductName.TabIndex = 2;
            labelProductName.Text = "Наименование продукта";
            // 
            // labelProductArtc
            // 
            labelProductArtc.AutoSize = true;
            labelProductArtc.Location = new Point(148, 38);
            labelProductArtc.Name = "labelProductArtc";
            labelProductArtc.Size = new Size(53, 15);
            labelProductArtc.TabIndex = 3;
            labelProductArtc.Text = "Артикул";
            // 
            // labelProductMaterials
            // 
            labelProductMaterials.AutoSize = true;
            labelProductMaterials.Location = new Point(148, 64);
            labelProductMaterials.Name = "labelProductMaterials";
            labelProductMaterials.Size = new Size(77, 15);
            labelProductMaterials.TabIndex = 4;
            labelProductMaterials.Text = "Материалы: ";
            // 
            // labelProductLine
            // 
            labelProductLine.AutoSize = true;
            labelProductLine.Font = new Font("Segoe UI", 11F);
            labelProductLine.Location = new Point(247, 17);
            labelProductLine.Name = "labelProductLine";
            labelProductLine.Size = new Size(13, 20);
            labelProductLine.TabIndex = 5;
            labelProductLine.Text = "|";
            // 
            // labelProductCost
            // 
            labelProductCost.AutoSize = true;
            labelProductCost.Location = new Point(532, 21);
            labelProductCost.Name = "labelProductCost";
            labelProductCost.Size = new Size(67, 15);
            labelProductCost.TabIndex = 6;
            labelProductCost.Text = "Стоимость";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelProductCost);
            Controls.Add(labelProductLine);
            Controls.Add(labelProductMaterials);
            Controls.Add(labelProductArtc);
            Controls.Add(labelProductName);
            Controls.Add(labelProductType);
            Controls.Add(pictureOfProduct);
            MaximumSize = new Size(615, 111);
            MinimumSize = new Size(615, 111);
            Name = "Product";
            Size = new Size(613, 109);
            ((System.ComponentModel.ISupportInitialize)pictureOfProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelProductLine;
        public Label labelProductName;
        public PictureBox pictureOfProduct;
        public Label labelProductType;
        public Label labelProductArtc;
        public Label labelProductMaterials;
        public Label labelProductCost;
    }
}
