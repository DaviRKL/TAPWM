namespace PClasses
{
    partial class FrnMensalista
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_salario_mensal = new System.Windows.Forms.TextBox();
            this.txt_data_entrada = new System.Windows.Forms.TextBox();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.lbl_data_entrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Instância Mensalista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Instância Mensalista Passando Parâmetros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(330, 40);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(235, 26);
            this.txt_matricula.TabIndex = 2;
            this.txt_matricula.TextChanged += new System.EventHandler(this.txt_matricula_TextChanged);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(330, 97);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(235, 26);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_salario_mensal
            // 
            this.txt_salario_mensal.Location = new System.Drawing.Point(330, 150);
            this.txt_salario_mensal.Name = "txt_salario_mensal";
            this.txt_salario_mensal.Size = new System.Drawing.Size(235, 26);
            this.txt_salario_mensal.TabIndex = 4;
            // 
            // txt_data_entrada
            // 
            this.txt_data_entrada.Location = new System.Drawing.Point(330, 205);
            this.txt_data_entrada.Name = "txt_data_entrada";
            this.txt_data_entrada.Size = new System.Drawing.Size(235, 26);
            this.txt_data_entrada.TabIndex = 5;
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(82, 46);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(73, 20);
            this.lbl_matricula.TabIndex = 6;
            this.lbl_matricula.Text = "Matrícula";
            this.lbl_matricula.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(82, 100);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(51, 20);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(82, 156);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(113, 20);
            this.lbl_salario.TabIndex = 8;
            this.lbl_salario.Text = "Salário Mensal";
            this.lbl_salario.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_data_entrada
            // 
            this.lbl_data_entrada.AutoSize = true;
            this.lbl_data_entrada.Location = new System.Drawing.Point(82, 211);
            this.lbl_data_entrada.Name = "lbl_data_entrada";
            this.lbl_data_entrada.Size = new System.Drawing.Size(217, 20);
            this.lbl_data_entrada.TabIndex = 9;
            this.lbl_data_entrada.Text = "Data de Entrada na Empresa";
            // 
            // FrnMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_data_entrada);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.txt_data_entrada);
            this.Controls.Add(this.txt_salario_mensal);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrnMensalista";
            this.Text = "FrnMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_salario_mensal;
        private System.Windows.Forms.TextBox txt_data_entrada;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label lbl_data_entrada;
    }
}