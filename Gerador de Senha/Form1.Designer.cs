namespace Gerador_de_Senha
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
            btngerar = new Button();
            label1 = new Label();
            txtsenha = new TextBox();
            btncopiar = new Button();
            chkMaiusculas = new CheckBox();
            chkMinusculas = new CheckBox();
            chkNumeros = new CheckBox();
            chkEspeciais = new CheckBox();
            SuspendLayout();
            // 
            // btngerar
            // 
            btngerar.Location = new Point(180, 31);
            btngerar.Name = "btngerar";
            btngerar.Size = new Size(75, 23);
            btngerar.TabIndex = 0;
            btngerar.Text = "Gerar";
            btngerar.UseVisualStyleBackColor = true;
            btngerar.Click += btngerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Senha Gerada:";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(14, 31);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(160, 23);
            txtsenha.TabIndex = 2;
            // 
            // btncopiar
            // 
            btncopiar.Location = new Point(261, 31);
            btncopiar.Name = "btncopiar";
            btncopiar.Size = new Size(75, 23);
            btncopiar.TabIndex = 3;
            btncopiar.Text = "Copiar";
            btncopiar.UseVisualStyleBackColor = true;
            btncopiar.Click += btncopiar_Click;
            // 
            // chkMaiusculas
            // 
            chkMaiusculas.AutoSize = true;
            chkMaiusculas.Location = new Point(17, 62);
            chkMaiusculas.Name = "chkMaiusculas";
            chkMaiusculas.Size = new Size(85, 19);
            chkMaiusculas.TabIndex = 4;
            chkMaiusculas.Text = "Maiusculas";
            chkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // chkMinusculas
            // 
            chkMinusculas.AutoSize = true;
            chkMinusculas.Location = new Point(106, 60);
            chkMinusculas.Name = "chkMinusculas";
            chkMinusculas.Size = new Size(86, 19);
            chkMinusculas.TabIndex = 5;
            chkMinusculas.Text = "Minusculas";
            chkMinusculas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            chkNumeros.AutoSize = true;
            chkNumeros.Location = new Point(195, 60);
            chkNumeros.Name = "chkNumeros";
            chkNumeros.Size = new Size(75, 19);
            chkNumeros.TabIndex = 6;
            chkNumeros.Text = "Numeros";
            chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkEspeciais
            // 
            chkEspeciais.AutoSize = true;
            chkEspeciais.Location = new Point(276, 60);
            chkEspeciais.Name = "chkEspeciais";
            chkEspeciais.Size = new Size(73, 19);
            chkEspeciais.TabIndex = 7;
            chkEspeciais.Text = "Especiais";
            chkEspeciais.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 91);
            Controls.Add(chkEspeciais);
            Controls.Add(chkNumeros);
            Controls.Add(chkMinusculas);
            Controls.Add(chkMaiusculas);
            Controls.Add(btncopiar);
            Controls.Add(txtsenha);
            Controls.Add(label1);
            Controls.Add(btngerar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btngerar;
        private Label label1;
        private TextBox txtsenha;
        private Button btncopiar;
        private CheckBox chkMaiusculas;
        private CheckBox chkMinusculas;
        private CheckBox chkNumeros;
        private CheckBox chkEspeciais;
    }
}
