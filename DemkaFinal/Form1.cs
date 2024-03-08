using Npgsql;
using System.Data;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemkaFinal
{
    public partial class Form1 : Form
    {
        int endpage = 0;
        int currentMinPage = 0;
        int currentPage = 1;
        public static DataSet ds;
        public static DataTable dt;
        public static NpgsqlConnection connString = new NpgsqlConnection("Host=localhost;Port=5432;Database=demka;Username=postgres;Password=1234");

        public Form1()
        {
            InitializeComponent();
            setEndPage();
            productToUser();
            pageToUser(currentMinPage);
        }

        public void setEndPage()
        {
            SQLtoDB("SELECT * FROM product ORDER BY id ASC");
            if (dt.Rows.Count % 20 != 0)
            {
                endpage = dt.Rows.Count / 20 + 1;
            }
            else
            {
                endpage = dt.Rows.Count / 20;
            }
        }

        public void productToUser()
        {
            flowLayoutPanelProducts.Controls.Clear();
            SQLtoDB("SELECT * FROM product ORDER BY id ASC");
            for (int i = 0 + (20 * (currentPage - 1)); i < 20 + (20 * (currentPage - 1)); i++)
            {
                Product product = new Product();
                product.Size = new Size(615, 111);
                product.labelProductType.Text = dt.Rows[i][2].ToString();
                product.labelProductName.Text = dt.Rows[i][1].ToString();
                product.labelProductArtc.Text = dt.Rows[i][3].ToString();
                product.labelProductCost.Text = dt.Rows[i][5].ToString();
                if (dt.Rows[i][4].ToString() != "нет" && dt.Rows[i][4].ToString() != "не указано" && dt.Rows[i][4].ToString() != "отсутствует" && dt.Rows[i][4].ToString() != "")
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
                if (currentMinPage + 4 != endpage)
                {
                    currentMinPage++;
                    pageToUser(currentMinPage);
                }    
            }
            else
            {
                currentPage = Convert.ToInt32(label.Text);
                productToUser();
            }
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
