namespace Forms
{
    partial class Registrar
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
            label3 = new Label();
            label4 = new Label();
            txbNome = new TextBox();
            txbUsuario = new TextBox();
            txbSenha = new TextBox();
            txbRepitaSenha = new TextBox();
            btRegistrar = new Button();
            lblUsuario = new Label();
            lblConfirmaSenha = new Label();
            lblNome = new Label();
            lblSenha = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 75);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 147);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 147);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Repita a Senha:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(12, 94);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(173, 23);
            txbNome.TabIndex = 4;
            // 
            // txbUsuario
            // 
            txbUsuario.BackColor = SystemColors.Window;
            txbUsuario.ForeColor = SystemColors.MenuText;
            txbUsuario.Location = new Point(191, 94);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(173, 23);
            txbUsuario.TabIndex = 5;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(13, 165);
            txbSenha.MaxLength = 16;
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(172, 23);
            txbSenha.TabIndex = 6;
            // 
            // txbRepitaSenha
            // 
            txbRepitaSenha.Location = new Point(191, 165);
            txbRepitaSenha.MaxLength = 16;
            txbRepitaSenha.Name = "txbRepitaSenha";
            txbRepitaSenha.PasswordChar = '*';
            txbRepitaSenha.Size = new Size(173, 23);
            txbRepitaSenha.TabIndex = 7;
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(305, 210);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(75, 23);
            btRegistrar.TabIndex = 8;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.Red;
            lblUsuario.Location = new Point(191, 120);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(12, 15);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "*";
            lblUsuario.Visible = false;
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.ForeColor = Color.Red;
            lblConfirmaSenha.Location = new Point(191, 191);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(12, 15);
            lblConfirmaSenha.TabIndex = 10;
            lblConfirmaSenha.Text = "*";
            lblConfirmaSenha.Visible = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.Red;
            lblNome.Location = new Point(12, 120);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(12, 15);
            lblNome.TabIndex = 11;
            lblNome.Text = "*";
            lblNome.Visible = false;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.ForeColor = Color.Red;
            lblSenha.Location = new Point(13, 191);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(12, 15);
            lblSenha.TabIndex = 12;
            lblSenha.Text = "*";
            lblSenha.Visible = false;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 239);
            Controls.Add(lblSenha);
            Controls.Add(lblNome);
            Controls.Add(lblConfirmaSenha);
            Controls.Add(lblUsuario);
            Controls.Add(btRegistrar);
            Controls.Add(txbRepitaSenha);
            Controls.Add(txbSenha);
            Controls.Add(txbUsuario);
            Controls.Add(txbNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrar";
            Text = "Registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbNome;
        private TextBox txbUsuario;
        private TextBox txbSenha;
        private TextBox txbRepitaSenha;
        private Button btRegistrar;
        private Label lblUsuario;
        private Label lblConfirmaSenha;
        private Label lblNome;
        private Label lblSenha;
    }
}