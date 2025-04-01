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
            btSalvar.Location = new Point(338, 84);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(257, 84);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 119);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(txbSobrenome);
            Controls.Add(txbNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroContato";
            Text = "CadastroContato";
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
    }
}