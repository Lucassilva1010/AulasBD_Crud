namespace AulaDiogo
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
            btnConexaoMyslq = new Button();
            label1 = new Label();
            btnConexaoSql = new Button();
            btnListarMysql = new Button();
            btnListarSql = new Button();
            listBoxMysql = new ListBox();
            listBoxSql = new ListBox();
            buttonMysqlSet = new Button();
            buttonSqlSet = new Button();
            dataGridViewMysql = new DataGridView();
            dataGridViewSql = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMysql).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSql).BeginInit();
            SuspendLayout();
            // 
            // btnConexaoMyslq
            // 
            btnConexaoMyslq.Location = new Point(127, 24);
            btnConexaoMyslq.Name = "btnConexaoMyslq";
            btnConexaoMyslq.Size = new Size(156, 79);
            btnConexaoMyslq.TabIndex = 0;
            btnConexaoMyslq.Text = "Conexão MySql";
            btnConexaoMyslq.UseVisualStyleBackColor = true;
            btnConexaoMyslq.Click += btnConexaoMyslq_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 31);
            label1.TabIndex = 1;
            label1.Text = "ADo.Net";
            label1.Click += label1_Click;
            // 
            // btnConexaoSql
            // 
            btnConexaoSql.Location = new Point(317, 23);
            btnConexaoSql.Name = "btnConexaoSql";
            btnConexaoSql.Size = new Size(207, 80);
            btnConexaoSql.TabIndex = 2;
            btnConexaoSql.Text = "Conexão SQL";
            btnConexaoSql.UseVisualStyleBackColor = true;
            btnConexaoSql.Click += btnConexaoSql_Click;
            // 
            // btnListarMysql
            // 
            btnListarMysql.Location = new Point(35, 109);
            btnListarMysql.Name = "btnListarMysql";
            btnListarMysql.Size = new Size(214, 48);
            btnListarMysql.TabIndex = 3;
            btnListarMysql.Text = "Listar MySql [Data Reader]";
            btnListarMysql.UseVisualStyleBackColor = true;
            btnListarMysql.Click += btnListarMysql_Click;
            // 
            // btnListarSql
            // 
            btnListarSql.Location = new Point(459, 109);
            btnListarSql.Name = "btnListarSql";
            btnListarSql.Size = new Size(243, 48);
            btnListarSql.TabIndex = 4;
            btnListarSql.Text = "Listar Sql [Data Reader]";
            btnListarSql.UseVisualStyleBackColor = true;
            btnListarSql.Click += btnListarSql_Click;
            // 
            // listBoxMysql
            // 
            listBoxMysql.FormattingEnabled = true;
            listBoxMysql.ItemHeight = 20;
            listBoxMysql.Location = new Point(12, 163);
            listBoxMysql.Name = "listBoxMysql";
            listBoxMysql.Size = new Size(367, 264);
            listBoxMysql.TabIndex = 5;
            // 
            // listBoxSql
            // 
            listBoxSql.FormattingEnabled = true;
            listBoxSql.ItemHeight = 20;
            listBoxSql.Location = new Point(435, 163);
            listBoxSql.Name = "listBoxSql";
            listBoxSql.Size = new Size(362, 264);
            listBoxSql.TabIndex = 6;
            // 
            // buttonMysqlSet
            // 
            buttonMysqlSet.Location = new Point(12, 433);
            buttonMysqlSet.Name = "buttonMysqlSet";
            buttonMysqlSet.Size = new Size(214, 48);
            buttonMysqlSet.TabIndex = 7;
            buttonMysqlSet.Text = "Listar MySql [Data Set]";
            buttonMysqlSet.UseVisualStyleBackColor = true;
            buttonMysqlSet.Click += buttonMySqlSet_Click;
            // 
            // buttonSqlSet
            // 
            buttonSqlSet.Location = new Point(459, 433);
            buttonSqlSet.Name = "buttonSqlSet";
            buttonSqlSet.Size = new Size(243, 48);
            buttonSqlSet.TabIndex = 8;
            buttonSqlSet.Text = "Listar Sql [Data Set]";
            buttonSqlSet.UseVisualStyleBackColor = true;
            buttonSqlSet.Click += buttonSqlSet_Click;
            // 
            // dataGridViewMysql
            // 
            dataGridViewMysql.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMysql.Location = new Point(12, 500);
            dataGridViewMysql.Name = "dataGridViewMysql";
            dataGridViewMysql.RowHeadersWidth = 51;
            dataGridViewMysql.RowTemplate.Height = 29;
            dataGridViewMysql.Size = new Size(352, 215);
            dataGridViewMysql.TabIndex = 9;
            dataGridViewMysql.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewSql
            // 
            dataGridViewSql.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSql.Location = new Point(435, 500);
            dataGridViewSql.Name = "dataGridViewSql";
            dataGridViewSql.RowHeadersWidth = 51;
            dataGridViewSql.RowTemplate.Height = 29;
            dataGridViewSql.Size = new Size(353, 215);
            dataGridViewSql.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 721);
            Controls.Add(dataGridViewSql);
            Controls.Add(dataGridViewMysql);
            Controls.Add(buttonSqlSet);
            Controls.Add(buttonMysqlSet);
            Controls.Add(listBoxSql);
            Controls.Add(listBoxMysql);
            Controls.Add(btnListarSql);
            Controls.Add(btnListarMysql);
            Controls.Add(btnConexaoSql);
            Controls.Add(label1);
            Controls.Add(btnConexaoMyslq);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMysql).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSql).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConexaoMyslq;
        private Label label1;
        private Button btnConexaoSql;
        private Button btnListarMysql;
        private Button btnListarSql;
        private ListBox listBoxMysql;
        private ListBox listBoxSql;
        private Button buttonMysqlSet;
        private Button buttonSqlSet;
        private DataGridView dataGridViewMysql;
        private DataGridView dataGridViewSql;
    }
}