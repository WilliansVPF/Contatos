namespace Forms
{
    partial class EnderecosContato
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
            txbIdContato = new TextBox();
            txbSobrenome = new TextBox();
            txbNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gvEnderecoContato = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Observacao = new DataGridViewTextBoxColumn();
            btNovo = new Button();
            btEditar = new Button();
            btExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)gvEnderecoContato).BeginInit();
            SuspendLayout();
            // 
            // txbIdContato
            // 
            txbIdContato.Location = new Point(12, 12);
            txbIdContato.Name = "txbIdContato";
            txbIdContato.Size = new Size(100, 23);
            txbIdContato.TabIndex = 13;
            txbIdContato.Visible = false;
            // 
            // txbSobrenome
            // 
            txbSobrenome.Enabled = false;
            txbSobrenome.Location = new Point(224, 56);
            txbSobrenome.Name = "txbSobrenome";
            txbSobrenome.ReadOnly = true;
            txbSobrenome.Size = new Size(189, 23);
            txbSobrenome.TabIndex = 12;
            // 
            // txbNome
            // 
            txbNome.Enabled = false;
            txbNome.Location = new Point(12, 56);
            txbNome.Name = "txbNome";
            txbNome.ReadOnly = true;
            txbNome.Size = new Size(189, 23);
            txbNome.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 38);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 10;
            label2.Text = "Sobrenome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 9;
            label1.Text = "Nome:";
            // 
            // gvEnderecoContato
            // 
            gvEnderecoContato.AllowUserToAddRows = false;
            gvEnderecoContato.AllowUserToDeleteRows = false;
            gvEnderecoContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvEnderecoContato.Columns.AddRange(new DataGridViewColumn[] { Id, Tipo, Valor, Observacao });
            gvEnderecoContato.Location = new Point(12, 85);
            gvEnderecoContato.Name = "gvEnderecoContato";
            gvEnderecoContato.ReadOnly = true;
            gvEnderecoContato.RowHeadersVisible = false;
            gvEnderecoContato.Size = new Size(579, 255);
            gvEnderecoContato.TabIndex = 14;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Resizable = DataGridViewTriState.True;
            Valor.Width = 300;
            // 
            // Observacao
            // 
            Observacao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Observacao.HeaderText = "Observação";
            Observacao.Name = "Observacao";
            Observacao.ReadOnly = true;
            // 
            // btNovo
            // 
            btNovo.BackColor = Color.SeaGreen;
            btNovo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNovo.ForeColor = SystemColors.ControlLightLight;
            btNovo.Location = new Point(477, 346);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(114, 39);
            btNovo.TabIndex = 15;
            btNovo.Text = "Novo Endereço de Contato";
            btNovo.UseVisualStyleBackColor = false;
            btNovo.Click += btNovo_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Gold;
            btEditar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEditar.ForeColor = SystemColors.ControlText;
            btEditar.Location = new Point(356, 346);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(114, 39);
            btEditar.TabIndex = 16;
            btEditar.Text = "Editar Endereço de Contato";
            btEditar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Red;
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btExcluir.ForeColor = SystemColors.ControlLightLight;
            btExcluir.Location = new Point(236, 346);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(114, 39);
            btExcluir.TabIndex = 17;
            btExcluir.Text = "Excluir Endereço de Contato";
            btExcluir.UseVisualStyleBackColor = false;
            // 
            // EnderecosContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 395);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btNovo);
            Controls.Add(gvEnderecoContato);
            Controls.Add(txbIdContato);
            Controls.Add(txbSobrenome);
            Controls.Add(txbNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EnderecosContato";
            Text = "CadastroEnderecoContato";
            Load += EnderecosContato_Load;
            ((System.ComponentModel.ISupportInitialize)gvEnderecoContato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbIdContato;
        private TextBox txbSobrenome;
        private TextBox txbNome;
        private Label label2;
        private Label label1;
        private DataGridView gvEnderecoContato;
        private Button btNovo;
        private Button btEditar;
        private Button btExcluir;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Observacao;
    }
}