namespace BancoDeDadosTI20N
{
    partial class Cadastrar
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
            this.Cadastro = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Endereço = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.Location = new System.Drawing.Point(79, 45);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(84, 24);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(13, 123);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(30, 13);
            this.CPF.TabIndex = 1;
            this.CPF.Text = "CPF";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(12, 163);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(39, 13);
            this.Nome.TabIndex = 3;
            this.Nome.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(13, 206);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(57, 13);
            this.Telefone.TabIndex = 5;
            this.Telefone.Text = "Telefone";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Endereço
            // 
            this.Endereço.AutoSize = true;
            this.Endereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereço.Location = new System.Drawing.Point(12, 241);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(61, 13);
            this.Endereço.TabIndex = 7;
            this.Endereço.Text = "Endereço";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 241);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(123, 321);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 54);
            this.Cancelar.TabIndex = 10;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 450);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Cadastro);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancelar;
    }
}