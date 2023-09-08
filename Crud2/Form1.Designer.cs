namespace Crud2
{
    partial class Form1
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
            labelCor = new Label();
            textBoxCor = new TextBox();
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelId = new Label();
            textBoxId = new TextBox();
            dataGridView1 = new DataGridView();
            labelMySql = new Label();
            btnBuscaTodosMySql = new Button();
            btnDeletarMySql = new Button();
            btnAlterarMySql = new Button();
            btnIncluirMySql = new Button();
            btnBuscarMySql = new Button();
            labelSql = new Label();
            btnBuscaTodosSql = new Button();
            btnDeletarSql = new Button();
            btnAlterarSql = new Button();
            btnIncluirSql = new Button();
            btnBuscarSql = new Button();
            btnBuscaSql = new Button();
            btnBuscaMySql = new Button();
            btnDeleteSql = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(795, 49);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(32, 20);
            labelCor.TabIndex = 37;
            labelCor.Text = "Cor";
            // 
            // textBoxCor
            // 
            textBoxCor.Location = new Point(795, 72);
            textBoxCor.Name = "textBoxCor";
            textBoxCor.Size = new Size(125, 27);
            textBoxCor.TabIndex = 36;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(602, 49);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 35;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(602, 72);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(125, 27);
            textBoxNome.TabIndex = 34;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(393, 49);
            labelId.Name = "labelId";
            labelId.Size = new Size(24, 20);
            labelId.TabIndex = 33;
            labelId.Text = "ID";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(393, 72);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(411, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(948, 523);
            dataGridView1.TabIndex = 31;
            // 
            // labelMySql
            // 
            labelMySql.AutoSize = true;
            labelMySql.Location = new Point(-181, 174);
            labelMySql.Name = "labelMySql";
            labelMySql.Size = new Size(120, 20);
            labelMySql.TabIndex = 30;
            labelMySql.Text = "CRUD do MySQL";
            // 
            // btnBuscaTodosMySql
            // 
            btnBuscaTodosMySql.Location = new Point(109, 364);
            btnBuscaTodosMySql.Name = "btnBuscaTodosMySql";
            btnBuscaTodosMySql.Size = new Size(242, 31);
            btnBuscaTodosMySql.TabIndex = 29;
            btnBuscaTodosMySql.Text = "Buscar Todos";
            btnBuscaTodosMySql.UseVisualStyleBackColor = true;
            // 
            // btnDeletarMySql
            // 
            btnDeletarMySql.Location = new Point(-201, 251);
            btnDeletarMySql.Name = "btnDeletarMySql";
            btnDeletarMySql.Size = new Size(123, 31);
            btnDeletarMySql.TabIndex = 28;
            btnDeletarMySql.Text = "Deletar";
            btnDeletarMySql.UseVisualStyleBackColor = true;
            // 
            // btnAlterarMySql
            // 
            btnAlterarMySql.Location = new Point(223, 327);
            btnAlterarMySql.Name = "btnAlterarMySql";
            btnAlterarMySql.Size = new Size(123, 31);
            btnAlterarMySql.TabIndex = 27;
            btnAlterarMySql.Text = "Alterar";
            btnAlterarMySql.UseVisualStyleBackColor = true;
            // 
            // btnIncluirMySql
            // 
            btnIncluirMySql.Location = new Point(99, 327);
            btnIncluirMySql.Name = "btnIncluirMySql";
            btnIncluirMySql.Size = new Size(123, 31);
            btnIncluirMySql.TabIndex = 26;
            btnIncluirMySql.Text = "Incluir";
            btnIncluirMySql.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMySql
            // 
            btnBuscarMySql.Location = new Point(-201, 214);
            btnBuscarMySql.Name = "btnBuscarMySql";
            btnBuscarMySql.Size = new Size(123, 31);
            btnBuscarMySql.TabIndex = 25;
            btnBuscarMySql.Text = "Buscar";
            btnBuscarMySql.UseVisualStyleBackColor = true;
            // 
            // labelSql
            // 
            labelSql.AutoSize = true;
            labelSql.Location = new Point(-170, -41);
            labelSql.Name = "labelSql";
            labelSql.Size = new Size(100, 20);
            labelSql.TabIndex = 24;
            labelSql.Text = "CRUD do SQL";
            // 
            // btnBuscaTodosSql
            // 
            btnBuscaTodosSql.Location = new Point(120, 149);
            btnBuscaTodosSql.Name = "btnBuscaTodosSql";
            btnBuscaTodosSql.Size = new Size(242, 31);
            btnBuscaTodosSql.TabIndex = 23;
            btnBuscaTodosSql.Text = "Buscar Todos";
            btnBuscaTodosSql.UseVisualStyleBackColor = true;
            btnBuscaTodosSql.Click += btnBuscaTodosSql_Click;
            // 
            // btnDeletarSql
            // 
            btnDeletarSql.Location = new Point(-190, 36);
            btnDeletarSql.Name = "btnDeletarSql";
            btnDeletarSql.Size = new Size(123, 31);
            btnDeletarSql.TabIndex = 22;
            btnDeletarSql.Text = "Deletar";
            btnDeletarSql.UseVisualStyleBackColor = true;
            // 
            // btnAlterarSql
            // 
            btnAlterarSql.Location = new Point(234, 112);
            btnAlterarSql.Name = "btnAlterarSql";
            btnAlterarSql.Size = new Size(123, 31);
            btnAlterarSql.TabIndex = 21;
            btnAlterarSql.Text = "Alterar";
            btnAlterarSql.UseVisualStyleBackColor = true;
            btnAlterarSql.Click += btnAlterarSql_Click;
            // 
            // btnIncluirSql
            // 
            btnIncluirSql.Location = new Point(110, 112);
            btnIncluirSql.Name = "btnIncluirSql";
            btnIncluirSql.Size = new Size(123, 31);
            btnIncluirSql.TabIndex = 20;
            btnIncluirSql.Text = "Incluir";
            btnIncluirSql.UseVisualStyleBackColor = true;
            btnIncluirSql.Click += btnIncluirSql_Click;
            // 
            // btnBuscarSql
            // 
            btnBuscarSql.Location = new Point(-190, -1);
            btnBuscarSql.Name = "btnBuscarSql";
            btnBuscarSql.Size = new Size(123, 31);
            btnBuscarSql.TabIndex = 19;
            btnBuscarSql.Text = "Buscar";
            btnBuscarSql.UseVisualStyleBackColor = true;
            // 
            // btnBuscaSql
            // 
            btnBuscaSql.Location = new Point(27, 112);
            btnBuscaSql.Name = "btnBuscaSql";
            btnBuscaSql.Size = new Size(77, 31);
            btnBuscaSql.TabIndex = 38;
            btnBuscaSql.Text = "Buscar";
            btnBuscaSql.UseVisualStyleBackColor = true;
            btnBuscaSql.Click += btnBuscaSql_Click_1;
            // 
            // btnBuscaMySql
            // 
            btnBuscaMySql.Location = new Point(12, 327);
            btnBuscaMySql.Name = "btnBuscaMySql";
            btnBuscaMySql.Size = new Size(77, 31);
            btnBuscaMySql.TabIndex = 39;
            btnBuscaMySql.Text = "Buscar";
            btnBuscaMySql.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSql
            // 
            btnDeleteSql.Location = new Point(27, 149);
            btnDeleteSql.Name = "btnDeleteSql";
            btnDeleteSql.Size = new Size(77, 31);
            btnDeleteSql.TabIndex = 40;
            btnDeleteSql.Text = "Deletar";
            btnDeleteSql.UseVisualStyleBackColor = true;
            btnDeleteSql.Click += btnDeleteSql_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Maiandra GD", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(244, 29);
            label1.TabIndex = 41;
            label1.Text = "Usando o SQL Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Maiandra GD", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 276);
            label2.Name = "label2";
            label2.Size = new Size(244, 29);
            label2.TabIndex = 42;
            label2.Text = "Usando o SQL Server";
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 729);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeleteSql);
            Controls.Add(btnBuscaMySql);
            Controls.Add(btnBuscaSql);
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
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCor;
        private TextBox textBoxCor;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelId;
        private TextBox textBoxId;
        private DataGridView dataGridView1;
        private Label labelMySql;
        private Button btnBuscaTodosMySql;
        private Button btnDeletarMySql;
        private Button btnAlterarMySql;
        private Button btnIncluirMySql;
        private Button btnBuscarMySql;
        private Label labelSql;
        private Button btnBuscaTodosSql;
        private Button btnDeletarSql;
        private Button btnAlterarSql;
        private Button btnIncluirSql;
        private Button btnBuscarSql;
        private Button btnBuscaSql;
        private Button btnBuscaMySql;
        private Button btnDeleteSql;
        private Label label1;
        private Label label2;
    }
}