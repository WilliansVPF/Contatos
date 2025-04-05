namespace Forms
{
    partial class Main
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
            gvContatos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Sobrenome = new DataGridViewTextBoxColumn();
            btNovo = new Button();
            btEditar = new Button();
            btExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)gvContatos).BeginInit();
            SuspendLayout();
            // 
            // gvContatos
            // 
            gvContatos.AllowUserToAddRows = false;
            gvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvContatos.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Sobrenome });
            gvContatos.Location = new Point(12, 12);
            gvContatos.Name = "gvContatos";
            gvContatos.RowHeadersVisible = false;
            gvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvContatos.Size = new Size(344, 300);
            gvContatos.TabIndex = 0;
            gvContatos.CellDoubleClick += gvContatos_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Sobrenome
            // 
            Sobrenome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sobrenome.HeaderText = "Sobrenome";
            Sobrenome.Name = "Sobrenome";
            // 
            // btNovo
            // 
            btNovo.BackColor = Color.SeaGreen;
            btNovo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNovo.ForeColor = SystemColors.ControlLightLight;
            btNovo.Location = new Point(378, 12);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(114, 39);
            btNovo.TabIndex = 1;
            btNovo.Text = "Novo Contato";
            btNovo.UseVisualStyleBackColor = false;
            btNovo.Click += btNovo_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Gold;
            btEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEditar.ForeColor = SystemColors.ControlText;
            btEditar.Location = new Point(378, 57);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(114, 39);
            btEditar.TabIndex = 2;
            btEditar.Text = "Editar Contato";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Red;
            btExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btExcluir.ForeColor = SystemColors.ControlLightLight;
            btExcluir.Location = new Point(378, 102);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(114, 39);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir Contato";
            btExcluir.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 327);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btNovo);
            Controls.Add(gvContatos);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)gvContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvContatos;
        private Button btNovo;
        private Button btEditar;
        private Button btExcluir;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Sobrenome;
    }
}
