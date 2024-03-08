using Npgsql;
using System.Data;

namespace DemkaFinal
{
    public partial class Form1 : Form
    {
        int endpage = 1;
        int currentMinPage = 0;
        int currentPage = 1;
        string sqlCommand = "SELECT * FROM product ORDER BY id ASC";
        public static DataSet ds;
        public static DataTable dt;
        public static NpgsqlConnection connString = new NpgsqlConnection("Host=localhost;Port=5432;Database=demka;Username=postgres;Password=1234");

        public Form1()
        {
            InitializeComponent();
            productToUser(sqlCommand);
            pageToUser(currentMinPage);
            comboBoxFiltr.Items.AddRange(new string[] { "Тип1", "Тип2" });
            comboBoxSort.Items.AddRange(new string[] { "ASC", "DESC" });
        }

        public void setEndPage(string str)
        {
            SQLtoDB(str);
            if (dt.Rows.Count % 20 != 0)
            {
                endpage = dt.Rows.Count / 20 + 1;
            }
            else
            {
                endpage = dt.Rows.Count / 20;
            }
        }

        public void productToUser(string str)
        {
            flowLayoutPanelProducts.Controls.Clear();
            int iEnd = 20;
            setEndPage(str);
            if (currentPage == endpage)
            {
                if (dt.Rows.Count % 20 != 0)
                {
                    iEnd = dt.Rows.Count % 20;
                }
            }
            if (currentPage > endpage)
            {
                iEnd = 0;
            }
            for (int i = 0 + (20 * (currentPage - 1)); i < iEnd + (20 * (currentPage - 1)); i++)
            {
                Product product = new Product();
                product.Size = new Size(615, 111);
                product.labelProductType.Text = dt.Rows[i][2].ToString();
                product.labelProductName.Text = dt.Rows[i][1].ToString();
                product.labelProductArtc.Text = dt.Rows[i][3].ToString();
                product.labelProductCost.Text = dt.Rows[i][5].ToString();
                if (dt.Rows[i][4].ToString().StartsWith("\\"))
                {
                    product.pictureOfProduct.ImageLocation = $"C:\\Users\\USER_2.1\\Desktop\\Promezhutochny_kontrol\\Промежуточный контроль\\Сессия 1{dt.Rows[i][4].ToString()}";
                }
                else
                {
                    product.pictureOfProduct.ImageLocation = $"C:\\Users\\USER_2.1\\Desktop\\Promezhutochny_kontrol\\Промежуточный контроль\\Сессия 1\\picture.png";
                }
                product.pictureOfProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                flowLayoutPanelProducts.Controls.Add(product);
            }
        }

        public void pageToUser(int minPage)
        {
            flowLayoutPanel2.Controls.Clear();
            Label label = new Label();
            label.Size = new Size(15, 15);
            label.Text = "<";
            label.Click += labelChangePage_Click;
            flowLayoutPanel2.Controls.Add(label);
            for (int i = 0 + minPage; i < 4 + minPage; i++)
            {
                label = new Label();
                label.Size = new Size(15, 15);
                label.Text = $"{i + 1}";
                label.Click += labelChangePage_Click;
                flowLayoutPanel2.Controls.Add(label);
            }
            label = new Label();
            label.Size = new Size(15, 15);
            label.Text = ">";
            label.Click += labelChangePage_Click;
            flowLayoutPanel2.Controls.Add(label);
        }

        private void labelChangePage_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text == "<")
            {
                if (currentMinPage != 0)
                {
                    currentMinPage--;
                    pageToUser(currentMinPage);
                }
            }
            else if (label.Text == ">")
            {
                if (currentMinPage + 4 < endpage)
                {
                    currentMinPage++;
                    pageToUser(currentMinPage);
                }
            }
            else
            {
                currentPage = Convert.ToInt32(label.Text);
                productToUser(sqlCommand);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            string main = "SELECT * FROM product";
            bool where = false;
            string searchLetters = "";
            string sortType = "";
            string result = "";

            if (textBox1.Text != "")
            {
                sqlCommand = $"SELECT EXISTS ({main} WHERE title ILIKE '%{textBox1.Text}%');";
                SQLtoDB(sqlCommand);
                if (dt.Rows[0][0].ToString() == "True")
                {
                    searchLetters = $" title ILIKE '%{textBox1.Text}%'";
                    where = true;
                }
            }

            switch (comboBoxSort.SelectedIndex)
            {
                case -1:
                    sortType = " ORDER BY ID ASC";
                    break;
                case 0:
                    sortType = " ORDER BY ID ASC";
                    break;
                case 1:
                    sortType = " ORDER BY ID DESC";
                    break;
            }


            if (where)
            {
                result = $"{main} WHERE {searchLetters} {sortType}";
            }
            else
            {
                result = $"{main} {sortType}";
            }
            
            sqlCommand = result;
            productToUser(sqlCommand);
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void comboBoxFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        public static void SQLtoDB(string sql)
        {
            connString.Open();
            NpgsqlCommand command = new NpgsqlCommand(sql, connString);
            NpgsqlDataAdapter dataAd = new NpgsqlDataAdapter(sql, connString);
            ds = new DataSet();
            ds.Reset();
            dataAd.Fill(ds);
            dt = ds.Tables[0];
            connString.Close();
        }

        public static void SQLtoDBwithChanges(string sql)
        {
            connString.Open();
            NpgsqlCommand comm = new NpgsqlCommand(sql, connString);
            comm.ExecuteNonQuery();
            connString.Close();
        }
    }
}