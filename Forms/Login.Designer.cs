namespace Forms
{
    partial class Login
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
            button1 = new Button();
            txbSenha = new TextBox();
            label2 = new Label();
            txbLogin = new TextBox();
            label1 = new Label();
            lbRegistrar = new LinkLabel();
            lblErro1 = new Label();
            lblErro2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(68, 235);
            button1.Name = "button1";
            button1.Size = new Size(115, 36);
            button1.TabIndex = 9;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btEntrar_Click;
            // 
            // txbSenha
            // 
            txbSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSenha.Location = new Point(14, 181);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(228, 33);
            txbSenha.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 153);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 7;
            label2.Text = "Senha:";
            // 
            // txbLogin
            // 
            txbLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbLogin.Location = new Point(14, 102);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(228, 33);
            txbLogin.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 74);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 5;
            label1.Text = "Login:";
            // 
            // lbRegistrar
            // 
            lbRegistrar.AutoSize = true;
            lbRegistrar.Location = new Point(97, 274);
            lbRegistrar.Name = "lbRegistrar";
            lbRegistrar.Size = new Size(53, 15);
            lbRegistrar.TabIndex = 10;
            lbRegistrar.TabStop = true;
            lbRegistrar.Text = "Registrar";
            lbRegistrar.LinkClicked += lbRegistrar_LinkClicked;
            // 
            // lblErro1
            // 
            lblErro1.AutoSize = true;
            lblErro1.BackColor = Color.Red;
            lblErro1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErro1.ForeColor = SystemColors.ControlLightLight;
            lblErro1.Location = new Point(12, 28);
            lblErro1.Name = "lblErro1";
            lblErro1.Size = new Size(233, 20);
            lblErro1.TabIndex = 11;
            lblErro1.Text = "Usuario não encontrado ou Senha";
            lblErro1.Visible = false;
            // 
            // lblErro2
            // 
            lblErro2.AutoSize = true;
            lblErro2.BackColor = Color.Red;
            lblErro2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErro2.ForeColor = SystemColors.ControlLightLight;
            lblErro2.Location = new Point(100, 49);
            lblErro2.Name = "lblErro2";
            lblErro2.Size = new Size(68, 20);
            lblErro2.TabIndex = 12;
            lblErro2.Text = "incorreta";
            lblErro2.UseWaitCursor = true;
            lblErro2.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 344);
            Controls.Add(lblErro2);
            Controls.Add(lblErro1);
            Controls.Add(lbRegistrar);
            Controls.Add(button1);
            Controls.Add(txbSenha);
            Controls.Add(label2);
            Controls.Add(txbLogin);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(272, 383);
            MinimizeBox = false;
            MinimumSize = new Size(272, 383);
            Name = "Login";
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txbSenha;
        private Label label2;
        private TextBox txbLogin;
        private Label label1;
        private LinkLabel lbRegistrar;
        private Label lblErro1;
        private Label lblErro2;
    }
}