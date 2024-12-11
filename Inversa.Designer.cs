namespace MetodaGauss
{
    partial class Inversa
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
            input = new RichTextBox();
            output = new RichTextBox();
            buttonInversa = new Button();
            buttonMeniu = new Button();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(12, 300);
            input.Name = "input";
            input.Size = new Size(500, 326);
            input.TabIndex = 0;
            input.Text = "";
            input.TextChanged += input_TextChanged;
            // 
            // output
            // 
            output.Location = new Point(533, 12);
            output.Name = "output";
            output.Size = new Size(937, 929);
            output.TabIndex = 1;
            output.Text = "";
            output.TextChanged += output_TextChanged;
            // 
            // buttonInversa
            // 
            buttonInversa.Location = new Point(12, 632);
            buttonInversa.Name = "buttonInversa";
            buttonInversa.Size = new Size(500, 29);
            buttonInversa.TabIndex = 2;
            buttonInversa.Text = "Calculeaza Inversa";
            buttonInversa.UseVisualStyleBackColor = true;
            buttonInversa.Click += buttonInversa_Click;
            // 
            // buttonMeniu
            // 
            buttonMeniu.Location = new Point(12, 667);
            buttonMeniu.Name = "buttonMeniu";
            buttonMeniu.Size = new Size(500, 29);
            buttonMeniu.TabIndex = 3;
            buttonMeniu.Text = "Inapoi la meniul principal";
            buttonMeniu.UseVisualStyleBackColor = true;
            buttonMeniu.Click += buttonMeniu_Click;
            // 
            // Inversa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(buttonMeniu);
            Controls.Add(buttonInversa);
            Controls.Add(output);
            Controls.Add(input);
            Name = "Inversa";
            Text = "Inversa";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox input;
        private RichTextBox output;
        private Button buttonInversa;
        private Button buttonMeniu;
    }
}