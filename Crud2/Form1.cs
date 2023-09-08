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

namespace Crud2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection conn = new SqlConnection();//Instancia do banco
        string ConnectionString = $@"Server=(localdb)\MSSQLLocalDB;Database=Aula;";//Caminho do banco
        void ListarTodosSql()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * From Produtoss", ConnectionString);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);

            dataGridView1.DataSource = dataSet;
            dataGridView1.DataSource = dataSet.Tables[0];
        }


        private void btnBuscaTodosSql_Click(object sender, EventArgs e)
        {
            ListarTodosSql();
        }

        private void btnIncluirSql_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(ConnectionString);//Acessa a conexão
            SqlCommand comm = new SqlCommand();//Cria o Provider
            comm.Connection = conexao;//Carrega o Provider com a concexão 
            comm.CommandType = CommandType.Text;

            comm.CommandText = $"Insert Into Produtoss(Nome, Cor) Values(@Nome, @cor)";
            comm.Parameters.AddWithValue("@Nome", textBoxNome.Text);
            comm.Parameters.AddWithValue("@Cor", textBoxCor.Text);
            conexao.Open();//Abrindo o bando
            comm.ExecuteNonQuery();
            conexao.Close();//Abrindo o bando

            ListarTodosSql();

        }

        private void btnBuscaSql_Click_1(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter($"Select * From Produtoss Where Id= {textBoxId.Text}", ConnectionString);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btnAlterarSql_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(ConnectionString);//Acessa a conexão
            SqlCommand comm = new SqlCommand();//Cria o Provider
            comm.Connection = conexao;//Carrega o Provider com a concexão 
            comm.CommandType = CommandType.Text;

            comm.CommandText = $"Update Produtoss set Nome = @nome, Cor = @cor where Id = @Id";
            comm.Parameters.AddWithValue("@Nome", textBoxNome.Text);
            comm.Parameters.AddWithValue("@Cor", textBoxCor.Text);
            comm.Parameters.AddWithValue("@Id", textBoxId.Text);
            conexao.Open();//Abrindo o bando
            comm.ExecuteNonQuery();
            conexao.Close();//Abrindo o bando

            ListarTodosSql();
        }

        private void btnDeleteSql_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(ConnectionString);//Acessa a conexão
            SqlCommand comm = new SqlCommand();//Cria o Provider
            comm.Connection = conexao;//Carrega o Provider com a concexão 
            comm.CommandType = CommandType.Text;

            comm.CommandText = $"Delete From Produtoss where Id = @Id";
            comm.Parameters.AddWithValue("@Id", textBoxId.Text);
            conexao.Open();//Abrindo o bando
            comm.ExecuteNonQuery();
            conexao.Close();//Abrindo o bando

            ListarTodosSql();
        }

        
    }
}
