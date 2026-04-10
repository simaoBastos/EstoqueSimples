namespace EstoqueSimples
{
    partial class form1
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
            lblNome = new Label();
            lblQtd = new Label();
            txtNome = new TextBox();
            numQuantidade = new NumericUpDown();
            dgvEstoque = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            btnAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Calibri", 15F);
            lblNome.Location = new Point(148, 100);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(245, 37);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do Produto:";
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Font = new Font("Calibri", 15F);
            lblQtd.Location = new Point(53, 250);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(169, 37);
            lblQtd.TabIndex = 1;
            lblQtd.Text = "Quantidade:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(53, 170);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(434, 37);
            txtNome.TabIndex = 2;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(287, 250);
            numQuantidade.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(200, 37);
            numQuantidade.TabIndex = 3;
            // 
            // dgvEstoque
            // 
            dgvEstoque.BorderStyle = BorderStyle.None;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { Nome, Quantidade });
            dgvEstoque.Location = new Point(508, 100);
            dgvEstoque.MultiSelect = false;
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersWidth = 62;
            dgvEstoque.Size = new Size(440, 400);
            dgvEstoque.TabIndex = 4;
            // 
            // Nome
            // 
            Nome.Frozen = true;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 8;
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            Quantidade.Width = 150;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Calibri", 15F);
            btnAdicionar.Location = new Point(131, 340);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(300, 50);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Cadastrar no Estoque";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 522);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvEstoque);
            Controls.Add(numQuantidade);
            Controls.Add(txtNome);
            Controls.Add(lblQtd);
            Controls.Add(lblNome);
            Font = new Font("Calibri", 12F);
            Margin = new Padding(4);
            Name = "form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblQtd;
        private TextBox txtNome;
        private NumericUpDown numQuantidade;
        private DataGridView dgvEstoque;
        private Button btnAdicionar;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
    }
}
