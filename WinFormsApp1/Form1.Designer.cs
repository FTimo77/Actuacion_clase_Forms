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
            Label Nombre;
            textBoxNum1 = new TextBox();
            button1 = new Button();
            textBoxNum2 = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            Nombre = new Label();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(324, 108);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(60, 15);
            Nombre.TabIndex = 4;
            Nombre.Text = "Numero 1";
            // 
            // textBoxNum1
            // 
            textBoxNum1.Location = new Point(310, 126);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(106, 23);
            textBoxNum1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(310, 265);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonAgregar_Click;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Location = new Point(310, 194);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(116, 23);
            textBoxNum2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 176);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Numero 2";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(310, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Suma";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(372, 240);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(54, 19);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Resta";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Controls.Add(textBoxNum2);
            Controls.Add(button1);
            Controls.Add(textBoxNum1);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNum1;
        private Button button1;
        private TextBox textBoxNum2;
        private Label Nombre;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
