using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaDiogo
{
    public partial class Crud : Form
    {
        public Crud()
        {
            InitializeComponent();
        }
        void ListarTudoSql()
        {
            SqlConnection conn = new SqlConnection();//Instancia do banco
            conn.ConnectionString = $@"Server=(localdb)\MSSQLLocalDB;Database=Aula;";//Caminho do banco

            SqlDataAdapter da = new SqlDataAdapter("Select * From Produtoss", conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);

            //dataGridView1.DataSource = dataSet;
            dataGridView1.DataSource = dataSet.Tables[0];

        }
        void ListarTudoMySql()
        {
           
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "Server=localhost;Database=aulas;Uid=root;Pwd=root;";

                MySqlDataAdapter da = new MySqlDataAdapter("Select * From Produtoss", conn);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                //dataGridView1.DataSource = dataSet;
                dataGridView1.DataSource = dataSet.Tables[0];
            
        }
        private void btnBuscaTodosSql_Click(object sender, EventArgs e)
        {
            ListarTudoMySql();
        }
    }
}
