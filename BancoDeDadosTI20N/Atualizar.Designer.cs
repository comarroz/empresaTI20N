﻿namespace BancoDeDadosTI20N
{
    partial class Atualizar
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
            this.label1 = new System.Windows.Forms.Label();
            this.Campo = new System.Windows.Forms.Label();
            this.Dado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atualizar Dados";
            // 
            // Campo
            // 
            this.Campo.AutoSize = true;
            this.Campo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo.Location = new System.Drawing.Point(24, 196);
            this.Campo.Name = "Campo";
            this.Campo.Size = new System.Drawing.Size(64, 20);
            this.Campo.TabIndex = 1;
            this.Campo.Text = "Campo:";
            // 
            // Dado
            // 
            this.Dado.AutoSize = true;
            this.Dado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dado.Location = new System.Drawing.Point(24, 244);
            this.Dado.Name = "Dado";
            this.Dado.Size = new System.Drawing.Size(52, 20);
            this.Dado.TabIndex = 2;
            this.Dado.Text = "Dado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 65);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPF:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 8;
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 464);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Dado);
            this.Controls.Add(this.Campo);
            this.Controls.Add(this.label1);
            this.Name = "Atualizar";
            this.Text = "Atualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Campo;
        private System.Windows.Forms.Label Dado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
    }
}