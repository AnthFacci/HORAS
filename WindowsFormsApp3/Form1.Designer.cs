namespace WindowsFormsApp3
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
            this.cpf = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.valorhora = new System.Windows.Forms.Label();
            this.horastrabalhadas = new System.Windows.Forms.Label();
            this.salario = new System.Windows.Forms.Label();
            this.txtcalcular = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtvh = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(28, 33);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(50, 24);
            this.cpf.TabIndex = 0;
            this.cpf.Text = "CPF";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(29, 80);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(66, 24);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome";
            // 
            // valorhora
            // 
            this.valorhora.AutoSize = true;
            this.valorhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorhora.Location = new System.Drawing.Point(12, 131);
            this.valorhora.Name = "valorhora";
            this.valorhora.Size = new System.Drawing.Size(95, 20);
            this.valorhora.TabIndex = 2;
            this.valorhora.Text = "Valor Hora";
            // 
            // horastrabalhadas
            // 
            this.horastrabalhadas.AutoSize = true;
            this.horastrabalhadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horastrabalhadas.Location = new System.Drawing.Point(12, 176);
            this.horastrabalhadas.Name = "horastrabalhadas";
            this.horastrabalhadas.Size = new System.Drawing.Size(161, 20);
            this.horastrabalhadas.TabIndex = 3;
            this.horastrabalhadas.Text = "Horas Trabalhadas";
            // 
            // salario
            // 
            this.salario.AutoSize = true;
            this.salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario.Location = new System.Drawing.Point(28, 216);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(74, 24);
            this.salario.TabIndex = 4;
            this.salario.Text = "Salário";
            // 
            // txtcalcular
            // 
            this.txtcalcular.Location = new System.Drawing.Point(119, 283);
            this.txtcalcular.Name = "txtcalcular";
            this.txtcalcular.Size = new System.Drawing.Size(153, 52);
            this.txtcalcular.TabIndex = 5;
            this.txtcalcular.Text = "Calcular ";
            this.txtcalcular.UseVisualStyleBackColor = true;
            this.txtcalcular.Click += new System.EventHandler(this.txtcalcular_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(119, 80);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 20);
            this.txtname.TabIndex = 7;
            // 
            // txtvh
            // 
            this.txtvh.Location = new System.Drawing.Point(119, 133);
            this.txtvh.Name = "txtvh";
            this.txtvh.Size = new System.Drawing.Size(241, 20);
            this.txtvh.TabIndex = 8;
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(179, 178);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(181, 20);
            this.txtht.TabIndex = 9;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(119, 221);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.ReadOnly = true;
            this.txtsalario.Size = new System.Drawing.Size(241, 20);
            this.txtsalario.TabIndex = 10;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(119, 36);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(241, 20);
            this.txtcpf.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 371);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtht);
            this.Controls.Add(this.txtvh);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcalcular);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.horastrabalhadas);
            this.Controls.Add(this.valorhora);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label valorhora;
        private System.Windows.Forms.Label horastrabalhadas;
        private System.Windows.Forms.Label salario;
        private System.Windows.Forms.Button txtcalcular;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtvh;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.MaskedTextBox txtcpf;
    }
}

