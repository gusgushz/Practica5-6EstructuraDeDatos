namespace WinFormsApp1
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
            labelCambio = new Label();
            labelHanoi = new Label();
            labelResultCambio = new Label();
            labelResultHanoi = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonCambio = new Button();
            buttonHanoi = new Button();
            textBoxHanoi = new TextBox();
            textBoxCosto = new TextBox();
            textBoxDinero = new TextBox();
            labelHanoiPasos = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // labelCambio
            // 
            labelCambio.AutoSize = true;
            labelCambio.Location = new Point(118, 54);
            labelCambio.Name = "labelCambio";
            labelCambio.Size = new Size(61, 20);
            labelCambio.TabIndex = 0;
            labelCambio.Text = "Cambio";
            // 
            // labelHanoi
            // 
            labelHanoi.AutoSize = true;
            labelHanoi.Location = new Point(533, 63);
            labelHanoi.Name = "labelHanoi";
            labelHanoi.Size = new Size(49, 20);
            labelHanoi.TabIndex = 1;
            labelHanoi.Text = "Hanoi";
            // 
            // labelResultCambio
            // 
            labelResultCambio.AutoSize = true;
            labelResultCambio.Location = new Point(96, 356);
            labelResultCambio.Name = "labelResultCambio";
            labelResultCambio.Size = new Size(131, 20);
            labelResultCambio.TabIndex = 2;
            labelResultCambio.Text = "Resultado Cambio";
            // 
            // labelResultHanoi
            // 
            labelResultHanoi.AutoSize = true;
            labelResultHanoi.Location = new Point(462, 326);
            labelResultHanoi.Name = "labelResultHanoi";
            labelResultHanoi.Size = new Size(240, 20);
            labelResultHanoi.TabIndex = 3;
            labelResultHanoi.Text = "Resultado Numero de pasos Hanoi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 138);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese el número de discos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 138);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 5;
            label2.Text = "Ingrese costo del producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 236);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 6;
            label3.Text = "Ingrese dinero";
            // 
            // buttonCambio
            // 
            buttonCambio.Location = new Point(104, 305);
            buttonCambio.Name = "buttonCambio";
            buttonCambio.Size = new Size(94, 29);
            buttonCambio.TabIndex = 7;
            buttonCambio.Text = "Calcular";
            buttonCambio.UseVisualStyleBackColor = true;
            buttonCambio.Click += buttonCambio_Click;
            // 
            // buttonHanoi
            // 
            buttonHanoi.Location = new Point(547, 270);
            buttonHanoi.Name = "buttonHanoi";
            buttonHanoi.Size = new Size(94, 29);
            buttonHanoi.TabIndex = 8;
            buttonHanoi.Text = "Calcular";
            buttonHanoi.UseVisualStyleBackColor = true;
            buttonHanoi.Click += buttonHanoi_Click;
            // 
            // textBoxHanoi
            // 
            textBoxHanoi.Location = new Point(516, 195);
            textBoxHanoi.Name = "textBoxHanoi";
            textBoxHanoi.Size = new Size(125, 27);
            textBoxHanoi.TabIndex = 9;
            // 
            // textBoxCosto
            // 
            textBoxCosto.Location = new Point(110, 183);
            textBoxCosto.Name = "textBoxCosto";
            textBoxCosto.Size = new Size(125, 27);
            textBoxCosto.TabIndex = 10;
            // 
            // textBoxDinero
            // 
            textBoxDinero.Location = new Point(102, 264);
            textBoxDinero.Name = "textBoxDinero";
            textBoxDinero.Size = new Size(125, 27);
            textBoxDinero.TabIndex = 11;
            // 
            // labelHanoiPasos
            // 
            labelHanoiPasos.AutoSize = true;
            labelHanoiPasos.Location = new Point(476, 380);
            labelHanoiPasos.Name = "labelHanoiPasos";
            labelHanoiPasos.Size = new Size(161, 20);
            labelHanoiPasos.TabIndex = 12;
            labelHanoiPasos.Text = "Resultado Hanoi pasos";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(69, 403);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 104);
            listBox1.TabIndex = 13;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(434, 427);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(283, 244);
            listBox2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 718);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(labelHanoiPasos);
            Controls.Add(textBoxDinero);
            Controls.Add(textBoxCosto);
            Controls.Add(textBoxHanoi);
            Controls.Add(buttonHanoi);
            Controls.Add(buttonCambio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelResultHanoi);
            Controls.Add(labelResultCambio);
            Controls.Add(labelHanoi);
            Controls.Add(labelCambio);
            Name = "Form1";
            Text = "Practica 5 y 6";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCambio;
        private Label labelHanoi;
        private Label labelResultCambio;
        private Label labelResultHanoi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCambio;
        private Button buttonHanoi;
        private TextBox textBoxHanoi;
        private TextBox textBoxCosto;
        private TextBox textBoxDinero;
        private Label labelHanoiPasos;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}