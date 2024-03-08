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
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 52);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(628, 488);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 539);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
