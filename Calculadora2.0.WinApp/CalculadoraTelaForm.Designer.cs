namespace Calculadora2._0.WinApp
{
    partial class CalculadoraTelaForm
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
            panCalculo = new TableLayoutPanel();
            btn0 = new Button();
            btnLimpar = new Button();
            btnSomar = new Button();
            btnIgual = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSubtrair = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMultiplicar = new Button();
            btn6 = new Button();
            btnDividir = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            panel1 = new Panel();
            txtCalculo = new TextBox();
            txtNumeros = new TextBox();
            panCalculo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panCalculo
            // 
            panCalculo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panCalculo.ColumnCount = 4;
            panCalculo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panCalculo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panCalculo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panCalculo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panCalculo.Controls.Add(btn0, 0, 3);
            panCalculo.Controls.Add(btnLimpar, 0, 3);
            panCalculo.Controls.Add(btnSomar, 0, 3);
            panCalculo.Controls.Add(btnIgual, 0, 3);
            panCalculo.Controls.Add(btn2, 0, 2);
            panCalculo.Controls.Add(btn1, 0, 2);
            panCalculo.Controls.Add(btnSubtrair, 0, 2);
            panCalculo.Controls.Add(btn3, 0, 2);
            panCalculo.Controls.Add(btn5, 0, 1);
            panCalculo.Controls.Add(btn4, 0, 1);
            panCalculo.Controls.Add(btnMultiplicar, 0, 1);
            panCalculo.Controls.Add(btn6, 0, 1);
            panCalculo.Controls.Add(btnDividir, 3, 0);
            panCalculo.Controls.Add(btn9, 2, 0);
            panCalculo.Controls.Add(btn8, 1, 0);
            panCalculo.Controls.Add(btn7, 0, 0);
            panCalculo.Location = new Point(12, 149);
            panCalculo.Name = "panCalculo";
            panCalculo.RowCount = 4;
            panCalculo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panCalculo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panCalculo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panCalculo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panCalculo.Size = new Size(392, 243);
            panCalculo.TabIndex = 1;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(101, 183);
            btn0.Name = "btn0";
            btn0.Size = new Size(92, 57);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Dock = DockStyle.Fill;
            btnLimpar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(3, 183);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(92, 57);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "CE";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSomar
            // 
            btnSomar.Dock = DockStyle.Fill;
            btnSomar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnSomar.Image = Properties.Resources.adicao;
            btnSomar.Location = new Point(297, 183);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(92, 57);
            btnSomar.TabIndex = 13;
            btnSomar.Tag = "+";
            btnSomar.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Dock = DockStyle.Fill;
            btnIgual.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.Location = new Point(199, 183);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(92, 57);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(101, 123);
            btn2.Name = "btn2";
            btn2.Size = new Size(92, 54);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(3, 123);
            btn1.Name = "btn1";
            btn1.Size = new Size(92, 54);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Dock = DockStyle.Fill;
            btnSubtrair.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtrair.Image = Properties.Resources.subtracao;
            btnSubtrair.Location = new Point(297, 123);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(92, 54);
            btnSubtrair.TabIndex = 9;
            btnSubtrair.Tag = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(199, 123);
            btn3.Name = "btn3";
            btn3.Size = new Size(92, 54);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(101, 63);
            btn5.Name = "btn5";
            btn5.Size = new Size(92, 54);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(3, 63);
            btn4.Name = "btn4";
            btn4.Size = new Size(92, 54);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Dock = DockStyle.Fill;
            btnMultiplicar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicar.Image = Properties.Resources.multiplicação;
            btnMultiplicar.Location = new Point(297, 63);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(92, 54);
            btnMultiplicar.TabIndex = 5;
            btnMultiplicar.Tag = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(199, 63);
            btn6.Name = "btn6";
            btn6.Size = new Size(92, 54);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Dock = DockStyle.Fill;
            btnDividir.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnDividir.Image = Properties.Resources.divisão;
            btnDividir.Location = new Point(297, 3);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(92, 54);
            btnDividir.TabIndex = 3;
            btnDividir.Tag = "/";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(199, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(92, 54);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(101, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(92, 54);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(3, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(92, 54);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtCalculo);
            panel1.Controls.Add(txtNumeros);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 131);
            panel1.TabIndex = 2;
            // 
            // txtCalculo
            // 
            txtCalculo.Dock = DockStyle.Top;
            txtCalculo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtCalculo.Location = new Point(0, 0);
            txtCalculo.Name = "txtCalculo";
            txtCalculo.Size = new Size(392, 36);
            txtCalculo.TabIndex = 1;
            // 
            // txtNumeros
            // 
            txtNumeros.Dock = DockStyle.Bottom;
            txtNumeros.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumeros.Location = new Point(0, 70);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(392, 61);
            txtNumeros.TabIndex = 0;
            txtNumeros.TextChanged += textBox1_TextChanged;
            // 
            // CalculadoraTelaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 404);
            Controls.Add(panel1);
            Controls.Add(panCalculo);
            Name = "CalculadoraTelaForm";
            ShowIcon = false;
            Text = "Calculadora Academia do Programador";
            panCalculo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panCalculo;
        private Button btn7;
        private Button btnDividir;
        private Button btn9;
        private Button btn8;
        private Button btn0;
        private Button btnLimpar;
        private Button btnSomar;
        private Button btnIgual;
        private Button btn2;
        private Button btn1;
        private Button btnSubtrair;
        private Button btn3;
        private Button btn5;
        private Button btn4;
        private Button btnMultiplicar;
        private Button btn6;
        private Panel panel1;
        private TextBox txtNumeros;
        private TextBox txtCalculo;
    }
}