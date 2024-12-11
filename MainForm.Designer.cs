namespace MetodaGauss
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(405, 181);
            button1.Name = "button1";
            button1.Size = new Size(300, 60);
            button1.TabIndex = 0;
            button1.Text = "Inversa unei matrici patratice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(405, 271);
            button2.Name = "button2";
            button2.Size = new Size(300, 60);
            button2.TabIndex = 1;
            button2.Text = "Determinantul matricei";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 102);
            label1.Name = "label1";
            label1.Size = new Size(262, 20);
            label1.TabIndex = 2;
            label1.Text = "Vasile Robert Andrei - Eliminare Gauss";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Aplicatie Gauss";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}