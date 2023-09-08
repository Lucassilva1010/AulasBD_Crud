namespace AulaDiogo
{
    partial class Crud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuscarSql = new Button();
            btnIncluirSql = new Button();
            btnAlterarSql = new Button();
            btnDeletarSql = new Button();
            btnBuscaTodosSql = new Button();
            labelSql = new Label();
            labelMySql = new Label();
            btnBuscaTodosMySql = new Button();
            btnDeletarMySql = new Button();
            btnAlterarMySql = new Button();
            btnIncluirMySql = new Button();
            btnBuscarMySql = new Button();
            dataGridView1 = new DataGridView();
            textBoxId = new TextBox();
            labelId = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelCor = new Label();
            textBoxCor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarSql
            // 
            btnBuscarSql.Location = new Point(28, 89);
            btnBuscarSql.Name = "btnBuscarSql";
            btnBuscarSql.Size = new Size(123, 31);
            btnBuscarSql.TabIndex = 0;
            btnBuscarSql.Text = "Buscar";
            btnBuscarSql.UseVisualStyleBackColor = true;
            // 
            // btnIncluirSql
            // 
            btnIncluirSql.Location = new Point(157, 89);
            btnIncluirSql.Name = "btnIncluirSql";
            btnIncluirSql.Size = new Size(123, 31);
            btnIncluirSql.TabIndex = 1;
            btnIncluirSql.Text = "Incluir";
            btnIncluirSql.UseVisualStyleBackColor = true;
            // 
            // btnAlterarSql
            // 
            btnAlterarSql.Location = new Point(286, 89);
            btnAlterarSql.Name = "btnAlterarSql";
            btnAlterarSql.Size = new Size(123, 31);
            btnAlterarSql.TabIndex = 2;
            btnAlterarSql.Text = "Alterar";
            btnAlterarSql.UseVisualStyleBackColor = true;
            // 
            // btnDeletarSql
            // 
            btnDeletarSql.Location = new Point(28, 126);
            btnDeletarSql.Name = "btnDeletarSql";
            btnDeletarSql.Size = new Size(123, 31);
            btnDeletarSql.TabIndex = 3;
            btnDeletarSql.Text = "Deletar";
            btnDeletarSql.UseVisualStyleBackColor = true;
            // 
            // btnBuscaTodosSql
            // 
            btnBuscaTodosSql.Location = new Point(167, 126);
            btnBuscaTodosSql.Name = "btnBuscaTodosSql";
            btnBuscaTodosSql.Size = new Size(242, 31);
            btnBuscaTodosSql.TabIndex = 4;
            btnBuscaTodosSql.Text = "Buscar Todos";
            btnBuscaTodosSql.UseVisualStyleBackColor = true;
            btnBuscaTodosSql.Click += btnBuscaTodosSql_Click;
            // 
            // labelSql
            // 
            labelSql.AutoSize = true;
            labelSql.Location = new Point(48, 49);
            labelSql.Name = "labelSql";
            labelSql.Size = new Size(100, 20);
            labelSql.TabIndex = 5;
            labelSql.Text = "CRUD do SQL";
            // 
            // labelMySql
            // 
            labelMySql.AutoSize = true;
            labelMySql.Location = new Point(37, 264);
            labelMySql.Name = "labelMySql";
            labelMySql.Size = new Size(120, 20);
            labelMySql.TabIndex = 11;
            labelMySql.Text = "CRUD do MySQL";
            // 
            // btnBuscaTodosMySql
            // 
            btnBuscaTodosMySql.Location = new Point(156, 341);
            btnBuscaTodosMySql.Name = "btnBuscaTodosMySql";
            btnBuscaTodosMySql.Size = new Size(242, 31);
            btnBuscaTodosMySql.TabIndex = 10;
            btnBuscaTodosMySql.Text = "Buscar Todos";
            btnBuscaTodosMySql.UseVisualStyleBackColor = true;
            // 
            // btnDeletarMySql
            // 
            btnDeletarMySql.Location = new Point(17, 341);
            btnDeletarMySql.Name = "btnDeletarMySql";
            btnDeletarMySql.Size = new Size(123, 31);
            btnDeletarMySql.TabIndex = 9;
            btnDeletarMySql.Text = "Deletar";
            btnDeletarMySql.UseVisualStyleBackColor = true;
            // 
            // btnAlterarMySql
            // 
            btnAlterarMySql.Location = new Point(275, 304);
            btnAlterarMySql.Name = "btnAlterarMySql";
            btnAlterarMySql.Size = new Size(123, 31);
            btnAlterarMySql.TabIndex = 8;
            btnAlterarMySql.Text = "Alterar";
            btnAlterarMySql.UseVisualStyleBackColor = true;
            // 
            // btnIncluirMySql
            // 
            btnIncluirMySql.Location = new Point(146, 304);
            btnIncluirMySql.Name = "btnIncluirMySql";
            btnIncluirMySql.Size = new Size(123, 31);
            btnIncluirMySql.TabIndex = 7;
            btnIncluirMySql.Text = "Incluir";
            btnIncluirMySql.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMySql
            // 
            btnBuscarMySql.Location = new Point(17, 304);
            btnBuscarMySql.Name = "btnBuscarMySql";
            btnBuscarMySql.Size = new Size(123, 31);
            btnBuscarMySql.TabIndex = 6;
            btnBuscarMySql.Text = "Buscar";
            btnBuscarMySql.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(463, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(756, 523);
            dataGridView1.TabIndex = 12;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(445, 49);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 13;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(445, 26);
            labelId.Name = "labelId";
            labelId.Size = new Size(24, 20);
            labelId.TabIndex = 14;
            labelId.Text = "ID";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(654, 26);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 16;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(654, 49);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(125, 27);
            textBoxNome.TabIndex = 15;
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(847, 26);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(32, 20);
            labelCor.TabIndex = 18;
            labelCor.Text = "Cor";
            // 
            // textBoxCor
            // 
            textBoxCor.Location = new Point(847, 49);
            textBoxCor.Name = "textBoxCor";
            textBoxCor.Size = new Size(125, 27);
            textBoxCor.TabIndex = 17;
            // 
            // Crud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 641);
            Controls.Add(labelCor);
            Controls.Add(textBoxCor);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(labelId);
            Controls.Add(textBoxId);
            Controls.Add(dataGridView1);
            Controls.Add(labelMySql);
            Controls.Add(btnBuscaTodosMySql);
            Controls.Add(btnDeletarMySql);
            Controls.Add(btnAlterarMySql);
            Controls.Add(btnIncluirMySql);
            Controls.Add(btnBuscarMySql);
            Controls.Add(labelSql);
            Controls.Add(btnBuscaTodosSql);
            Controls.Add(btnDeletarSql);
            Controls.Add(btnAlterarSql);
            Controls.Add(btnIncluirSql);
            Controls.Add(btnBuscarSql);
            Name = "Crud";
            Text = "Crud";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarSql;
        private Button btnIncluirSql;
        private Button btnAlterarSql;
        private Button btnDeletarSql;
        private Button btnBuscaTodosSql;
        private Label labelSql;
        private Label labelMySql;
        private Button btnBuscaTodosMySql;
        private Button btnDeletarMySql;
        private Button btnAlterarMySql;
        private Button btnIncluirMySql;
        private Button btnBuscarMySql;
        private DataGridView dataGridView1;
        private TextBox textBoxId;
        private Label labelId;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelCor;
        private TextBox textBoxCor;
    }
}