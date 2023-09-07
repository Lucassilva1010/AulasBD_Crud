using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace AulaDiogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConexaoMyslq_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=aulas;Uid=root;Pwd=root;";
            conn.Open();
            //jdbc: mysql://localhost:3306/?user=root

            MessageBox.Show("Abrir conexão com MySql");
            conn.Close();  //Sempre que a conexão for aberta é necessario se fechada
        }

        private void btnConexaoSql_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();//Instancia do banco
            conn.ConnectionString = $@"Server=(localdb)\MSSQLLocalDB;Database=Aula;";//Caminho do banco
            conn.Open();//Abrindo o bando

            MessageBox.Show("Abrir conexão com SqlServer");
            conn.Close();  //Sempre fechar a conexão após a sua abertura
        }

        private void btnListarMysql_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=aulas;Uid=root;Pwd=root;";
            conn.Open();


            MySqlCommand comm = new MySqlCommand();

            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "Select *From Produtoss";
            comm.Connection = conn;

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                listBoxMysql.Items.Add($"{reader.GetInt32(0)}, {reader.GetString(1)}, {reader.GetString(2)}");
            }


            MessageBox.Show("Abrir conexão com MySql");
            conn.Close();  //Sempre que a conexão for aberta é necessario se fechada
        }

        private void btnListarSql_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();//Instancia do banco
            conn.ConnectionString = $@"Server=(localdb)\MSSQLLocalDB;Database=Aula;";//Caminho do banco
            conn.Open();//Abrindo o bando

            SqlCommand comm = new SqlCommand();

            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "Select *From Produtoss";
            comm.Connection = conn;

            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                listBoxSql.Items.Add($"{reader.GetInt32(0)}, {reader.GetString(1)}, {reader.GetString(2)}");
            }


            conn.Close();  //Sempre fechar a conexão após a sua abertura

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMySqlSet_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=aulas;Uid=root;Pwd=root;";

            MySqlDataAdapter da = new MySqlDataAdapter("Select * From Produtoss", conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);

            dataGridViewMysql.DataSource = dataSet;
            dataGridViewMysql.DataSource = dataSet.Tables[0];
        }

        private void buttonSqlSet_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();//Instancia do banco
            conn.ConnectionString = $@"Server=(localdb)\MSSQLLocalDB;Database=Aula;";//Caminho do banco
           
            SqlDataAdapter da = new SqlDataAdapter("Select * From Produtoss", conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);

            dataGridViewSql.DataSource = dataSet;
            dataGridViewSql.DataSource = dataSet.Tables[0];

            conn.Close();  //Sempre fechar a conexão após a sua abertura
        }
    }
}