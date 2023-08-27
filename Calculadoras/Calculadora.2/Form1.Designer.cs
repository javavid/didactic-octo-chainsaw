namespace Calculadora._2
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
            textvalor1 = new TextBox();
            textvalor2 = new TextBox();
            textresultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            botonsuma = new Button();
            botonresta = new Button();
            botondividir = new Button();
            botonmultiplicar = new Button();
            SuspendLayout();
            // 
            // textvalor1
            // 
            textvalor1.Location = new Point(17, 75);
            textvalor1.Margin = new Padding(4, 5, 4, 5);
            textvalor1.Name = "textvalor1";
            textvalor1.Size = new Size(347, 31);
            textvalor1.TabIndex = 0;
            // 
            // textvalor2
            // 
            textvalor2.Location = new Point(497, 75);
            textvalor2.Margin = new Padding(4, 5, 4, 5);
            textvalor2.Name = "textvalor2";
            textvalor2.Size = new Size(393, 31);
            textvalor2.TabIndex = 1;
            // 
            // textresultado
            // 
            textresultado.Location = new Point(17, 222);
            textresultado.Margin = new Padding(4, 5, 4, 5);
            textresultado.Name = "textresultado";
            textresultado.Size = new Size(873, 31);
            textresultado.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(17, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 40);
            label1.TabIndex = 3;
            label1.Text = "valor1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(497, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 40);
            label2.TabIndex = 4;
            label2.Text = "valor2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(17, 175);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 40);
            label3.TabIndex = 5;
            label3.Text = "resultado";
            // 
            // botonsuma
            // 
            botonsuma.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            botonsuma.ForeColor = SystemColors.WindowFrame;
            botonsuma.Location = new Point(17, 350);
            botonsuma.Margin = new Padding(4, 5, 4, 5);
            botonsuma.Name = "botonsuma";
            botonsuma.Size = new Size(181, 85);
            botonsuma.TabIndex = 6;
            botonsuma.Text = "Suma";
            botonsuma.UseVisualStyleBackColor = true;
            botonsuma.Click += botonsuma_Click;
            // 
            // botonresta
            // 
            botonresta.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            botonresta.ForeColor = SystemColors.WindowFrame;
            botonresta.Location = new Point(249, 350);
            botonresta.Margin = new Padding(4, 5, 4, 5);
            botonresta.Name = "botonresta";
            botonresta.Size = new Size(181, 85);
            botonresta.TabIndex = 7;
            botonresta.Text = "Resta";
            botonresta.UseVisualStyleBackColor = true;
            botonresta.Click += botonresta_Click;
            // 
            // botondividir
            // 
            botondividir.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            botondividir.ForeColor = SystemColors.WindowFrame;
            botondividir.Location = new Point(480, 350);
            botondividir.Margin = new Padding(4, 5, 4, 5);
            botondividir.Name = "botondividir";
            botondividir.Size = new Size(181, 85);
            botondividir.TabIndex = 8;
            botondividir.Text = "Dividir";
            botondividir.UseVisualStyleBackColor = true;
            botondividir.Click += botondividir_Click;
            // 
            // botonmultiplicar
            // 
            botonmultiplicar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            botonmultiplicar.ForeColor = SystemColors.WindowFrame;
            botonmultiplicar.Location = new Point(710, 350);
            botonmultiplicar.Margin = new Padding(4, 5, 4, 5);
            botonmultiplicar.Name = "botonmultiplicar";
            botonmultiplicar.Size = new Size(181, 85);
            botonmultiplicar.TabIndex = 9;
            botonmultiplicar.Text = "Multiplicar";
            botonmultiplicar.UseVisualStyleBackColor = true;
            botonmultiplicar.Click += botonmultiplicar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(909, 537);
            Controls.Add(botonmultiplicar);
            Controls.Add(botondividir);
            Controls.Add(botonresta);
            Controls.Add(botonsuma);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textresultado);
            Controls.Add(textvalor2);
            Controls.Add(textvalor1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textvalor1;
        private TextBox textvalor2;
        private TextBox textresultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button botonsuma;
        private Button botonresta;
        private Button botondividir;
        private Button botonmultiplicar;
    }
}