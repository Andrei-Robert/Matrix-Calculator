namespace MetodaGauss
{
    partial class Determinant
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
            buttonDeterminant = new Button();
            buttonMeniu = new Button();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(12, 258);
            input.Name = "input";
            input.Size = new Size(500, 293);
            input.TabIndex = 0;
            input.Text = "";
            input.TextChanged += input_TextChanged;
            // 
            // output
            // 
            output.Location = new Point(518, 12);
            output.Name = "output";
            output.Size = new Size(952, 929);
            output.TabIndex = 1;
            output.Text = "";
            output.TextChanged += output_TextChanged;
            // 
            // buttonDeterminant
            // 
            buttonDeterminant.Location = new Point(12, 557);
            buttonDeterminant.Name = "buttonDeterminant";
            buttonDeterminant.Size = new Size(500, 29);
            buttonDeterminant.TabIndex = 2;
            buttonDeterminant.Text = "Calculeaza Determinantul";
            buttonDeterminant.UseVisualStyleBackColor = true;
            buttonDeterminant.Click += buttonDeterminant_Click;
            // 
            // buttonMeniu
            // 
            buttonMeniu.Location = new Point(12, 592);
            buttonMeniu.Name = "buttonMeniu";
            buttonMeniu.Size = new Size(500, 29);
            buttonMeniu.TabIndex = 3;
            buttonMeniu.Text = "Inapoi la meniu principal";
            buttonMeniu.UseVisualStyleBackColor = true;
            buttonMeniu.Click += buttonMeniu_Click;
            // 
            // Determinant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(buttonMeniu);
            Controls.Add(buttonDeterminant);
            Controls.Add(output);
            Controls.Add(input);
            Name = "Determinant";
            Text = "Determinant";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox input;
        private RichTextBox output;
        private Button buttonDeterminant;
        private Button buttonMeniu;
    }
}