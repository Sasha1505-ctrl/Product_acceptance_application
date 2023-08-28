using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestTask
{
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string queryString = $"select id_provider from provider";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                cb_provider.Items.Add(reader.GetInt32(0));
            }
            reader.Close();

            string queryString2 = $"select id_product from product";

            SqlCommand command2 = new SqlCommand(queryString2, database.getConnection());

            database.openConnection();

            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                cb_product.Items.Add(reader2.GetInt32(0));
            }
            reader2.Close();
        }

        private void but_providers_Click(object sender, EventArgs e)
        {
            dgv_provider.Columns.Clear();
            dgv_provider.Columns.Add("id_provider", "id");
            dgv_provider.Columns.Add("name_provider", "Имя поставщика");

            dgv_provider.Rows.Clear();

            string queryString = $"select * from provider";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadRowProvider(dgv_provider, reader);
            }
            reader.Close();
        }

        private void but_products_Click(object sender, EventArgs e)
        {
            dgv_product.Columns.Clear();
            dgv_product.Columns.Add("id_product", "id");
            dgv_product.Columns.Add("variety", "Сорт");
            dgv_product.Columns.Add("price_per_kg", "Цена за кг");

            dgv_product.Rows.Clear();

            string queryString = $"select * from product";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadRowProduct(dgv_product, reader);
            }
            reader.Close();
        }

        private void but_receipt_Click(object sender, EventArgs e)
        {
            dgv_receipt.Columns.Clear();
            dgv_receipt.Columns.Add("id_account", "id");
            dgv_receipt.Columns.Add("provider", "id поставщика");
            dgv_receipt.Columns.Add("date_receipt", "Дата поставки");
            dgv_receipt.Columns.Add("id_product", "id продукта");
            dgv_receipt.Columns.Add("number_kg", "число кг");

            dgv_receipt.Rows.Clear();

            string queryString = $"select * from receipt";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadRowReceipt(dgv_receipt, reader);
            }
            reader.Close();
        }

        private void ReadRowProvider(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1));
        }
        private void ReadRowProduct(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2));
        }
        private void ReadRowReceipt(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetDateTime(2), record.GetInt32(3), record.GetInt32(4));
        }

        private void but_accept_receipt_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO receipt (provider, date_receipt, id_product, number_kg) values (@provider, @date_receipt, @id_product, @number_kg)", database.getConnection());

            command.Parameters.AddWithValue("provider", cb_provider.Text);
            command.Parameters.AddWithValue("date_receipt", dtp_receipt.Value);
            command.Parameters.AddWithValue("id_product", cb_product.Text);
            command.Parameters.AddWithValue("number_kg", tb_number_kg.Text);
            database.openConnection();
            command.ExecuteNonQuery();
        }

        private void make_report_Click(object sender, EventArgs e)
        {
            dgv_report.Columns.Clear();
            dgv_report.Columns.Add("provider", "id поставщика");
            dgv_report.Columns.Add("date_receipt", "Дата поставки");
            dgv_report.Columns.Add("id_product", "id продукта");
            dgv_report.Columns.Add("number_kg", "число кг");
            dgv_report.Columns.Add("price_per_kg", "цена за кг");
            dgv_report.Columns.Add("total_weight", "итоговый вес");
            dgv_report.Columns.Add("total_price", "итоговая стоимость");

            dgv_report.Rows.Clear();

            string queryString = "select receipt.provider, receipt.date_receipt, receipt.id_product, receipt.number_kg, product.price_per_kg, SUM(receipt.number_kg) as 'total_weight', SUM(receipt.number_kg * product.price_per_kg) as 'total_price' from receipt JOIN product ON receipt.id_product = product.id_product  WHERE receipt.date_receipt BETWEEN @dTPone AND @dTPtwo GROUP BY receipt.provider, receipt.date_receipt, receipt.id_product, receipt.number_kg, product.price_per_kg";
            
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            command.Parameters.AddWithValue("dTPone", dateTimePicker1.Value);
            command.Parameters.AddWithValue("dTPtwo", dateTimePicker2.Value);

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadRowReport(dgv_report, reader);
            }
            reader.Close();
        }
        private void ReadRowReport(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetDateTime(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetInt32(6));
        }

        private void make_provider_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO provider (name_provider) values (@name_provider)", database.getConnection());

            command.Parameters.AddWithValue("name_provider", tb_name_provider.Text);
            database.openConnection();
            command.ExecuteNonQuery();
        }

        private void make_product_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO product (variety, price_per_kg) values (@variety, @price_per_kg)", database.getConnection());

            command.Parameters.AddWithValue("variety", tb_variety.Text);
            command.Parameters.AddWithValue("price_per_kg", tb_price_per_kg.Text);
            database.openConnection();
            command.ExecuteNonQuery();
        }

    }
}
