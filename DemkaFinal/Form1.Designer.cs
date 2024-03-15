namespace DemkaFinal
{
    partial class Form1
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
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBoxSort = new ComboBox();
            comboBoxFiltr = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Location = new Point(0, 52);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(639, 488);
            flowLayoutPanelProducts.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 22);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Поиск";
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(371, 17);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(121, 23);
            comboBoxSort.TabIndex = 3;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // comboBoxFiltr
            // 
            comboBoxFiltr.FormattingEnabled = true;
            comboBoxFiltr.Location = new Point(509, 17);
            comboBoxFiltr.Name = "comboBoxFiltr";
            comboBoxFiltr.Size = new Size(121, 23);
            comboBoxFiltr.TabIndex = 4;
            comboBoxFiltr.SelectedIndexChanged += comboBoxFiltr_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, -1);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 5;
            label2.Text = "Фильтрация";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, -1);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "Сортировка";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Location = new Point(509, 546);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(130, 46);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 596);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxFiltr);
            Controls.Add(comboBoxSort);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanelProducts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBoxSort;
        private ComboBox comboBoxFiltr;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
