namespace Forms
{
    partial class CadastroContato
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
            label1 = new Label();
            label2 = new Label();
            txbNome = new TextBox();
            txbSobrenome = new TextBox();
            btSalvar = new Button();
            btCancelar = new Button();
            lblNome = new Label();
            lblSobrenome = new Label();
            txbId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 27);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Sobrenome";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(12, 45);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(189, 23);
            txbNome.TabIndex = 2;
            // 
            // txbSobrenome
            // 
            txbSobrenome.Location = new Point(224, 45);
            txbSobrenome.Name = "txbSobrenome";
            txbSobrenome.Size = new Size(189, 23);
            txbSobrenome.TabIndex = 3;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(338, 90);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(257, 90);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.Red;
            lblNome.Location = new Point(12, 71);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(118, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "* Campo Obrigatorio";
            lblNome.Visible = false;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.ForeColor = Color.Red;
            lblSobrenome.Location = new Point(224, 71);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(118, 15);
            lblSobrenome.TabIndex = 7;
            lblSobrenome.Text = "* Campo Obrigatorio";
            lblSobrenome.Visible = false;
            // 
            // txbId
            // 
            txbId.Location = new Point(12, 1);
            txbId.Name = "txbId";
            txbId.Size = new Size(100, 23);
            txbId.TabIndex = 8;
            txbId.Visible = false;
            // 
            // CadastroContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 119);
            Controls.Add(txbId);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(txbSobrenome);
            Controls.Add(txbNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroContato";
            Text = "CadastroContato";
            Load += CadastroContato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbNome;
        private TextBox txbSobrenome;
        private Button btSalvar;
        private Button btCancelar;
        private Label lblNome;
        private Label lblSobrenome;
        private TextBox txbId;
    }
}