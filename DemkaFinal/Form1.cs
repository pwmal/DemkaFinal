using Npgsql;
using System.Data;

namespace DemkaFinal
{
    public partial class Form1 : Form
    {
        public static DataSet ds;
        public static DataTable dt;
        public static NpgsqlConnection connString = new NpgsqlConnection("Host=localhost;Port=5432;Database=demka;Username=postgres;Password=1234");

        public Form1()
        {
            InitializeComponent();
            productToUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQLtoDBwithChanges($"INSERT INTO users (login, password) VALUES ('{textBox1.Text}', '{textBox2.Text}');");
        }

        public void productToUser()
        {
            SQLtoDB("SELECT * FROM product ORDER BY id ASC");
            for (int i = 0; i < 20; i++)
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
                flowLayoutPanel1.Controls.Add(product);
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
