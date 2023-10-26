namespace practica7
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
            label1 = new Label();
            label2 = new Label();
            valor = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            Resultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 53);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 68);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresa Valor:";
            // 
            // valor
            // 
            valor.Location = new Point(133, 65);
            valor.Name = "valor";
            valor.Size = new Size(85, 23);
            valor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 134);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 3;
            label3.Text = "Opciones de Conversion ";
            // 
            // button1
            // 
            button1.Location = new Point(34, 213);
            button1.Name = "button1";
            button1.Size = new Size(113, 34);
            button1.TabIndex = 4;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(186, 213);
            button2.Name = "button2";
            button2.Size = new Size(110, 34);
            button2.TabIndex = 5;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(108, 253);
            button3.Name = "button3";
            button3.Size = new Size(110, 35);
            button3.TabIndex = 6;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 310);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 7;
            label4.Text = "Resultado en Grados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 325);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 8;
            label5.Text = "Equivalente en Grados";
            // 
            // Resultado
            // 
            Resultado.Location = new Point(133, 352);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(85, 23);
            Resultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(373, 403);
            Controls.Add(Resultado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox valor;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private TextBox Resultado;
    }
}